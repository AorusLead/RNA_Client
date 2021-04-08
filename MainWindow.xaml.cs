using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using RNA_Client.ServiceReference2;

namespace RNA_Client
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// 
	public delegate void ApplySettings(bool taskmngr, bool startup, bool dontipport);
	public partial class MainWindow : Window, IService1Callback
	{
		private string ExePath = System.Windows.Forms.Application.ExecutablePath;
		private RegistryKey reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
		private RegistryKey addition = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RNA_Addition\\");
		private string PCName = System.Net.Dns.GetHostName();
		private System.Net.IPAddress IP = null;
		private Service1Client client1 = null;
		private RNA_Switcher switcher = null;
		private IService1Callback callback = null;
		private int Port = 0;
		

		public MainWindow()
		{
			bool? value = addition.GetValue(@"SettingsSetted") as bool?;
			//Проверка на наличие флажка автозапуска
			if (value == null || value == false)
			{
				Settings stngs = new Settings();
				stngs.ApplyingSettings += Stngs_ApplyingSettings;
				if (stngs.ShowDialog() == true) addition.SetValue(@"SettingsSetted", true);
			}
			value = addition.GetValue(@"DontSaveIpPort") as bool?;


			value = false;
			IP = System.Net.IPAddress.Parse("192.168.1.103");
			Port = 7777;

			callback = this as IService1Callback;
			//if (value != null)
			//{
			//	if (value == true)
			//		GetIpPort();
			//	else
			//	{
			//		System.Net.IPAddress.TryParse(addition.GetValue(@"IP").ToString(), out IP);
			//		Int32.TryParse(addition.GetValue(@"Port").ToString(), out Port);
			//		if (IP == null || Port == 0)
			//			GetIpPort();
			//	}
			//}
			//else
			//{
			//	GetIpPort();
			//}
			switcher = new RNA_Switcher();
			Connect();
			if (!client1.AddClient(PCName, System.Net.Dns.GetHostByName(PCName).AddressList[0]))
			{
				switch (MessageBox.Show("Рекомендуется сменить имя компьютера, либо же он будет продолжать работу под изменённым именем. Продолжить работу с новым именем ?", "Невозможно занять имя клиента", MessageBoxButton.YesNo))
				{
					case MessageBoxResult.Yes:
						PCName += new Random().Next(1, 10000);
						break;
					default:
						Disconnect();
						return;
				}
			}
			//InitializeComponent();
			//this.Visibility = Visibility.Collapsed;
		}

		private void Connect()
		{
			while (!TryConnect()) ;
		}

		private bool TryConnect()
		{
			try
			{
				client1 = new Service1Client(new InstanceContext(callback));
				return true;
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
		}

		private void GetIpPort()
		{
			Server server = new Server();
			server.ApplyingIpPort += Server_ApplyingIpPort;
			server.ShowDialog();
		}

		private void Server_ApplyingIpPort(System.Net.IPAddress Ip, int port)
		{
			IP = Ip;
			Port = port;

			addition.SetValue("IP", IP.ToString());
			addition.SetValue("Port", Port);
		}

		private void Stngs_ApplyingSettings(bool taskmngr, bool startup, bool dontipport)
		{
			if (taskmngr)
				DisableTaskMngr();
			if (startup)
				reg.SetValue(ExePath, true);
			else
				reg.SetValue(ExePath, false);
			if (dontipport)
				addition.SetValue(@"DontSaveIpPort", true);
			addition.SetValue("SettingsSetted", true);
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			//this.Visibility = Visibility.Collapsed;
		}

		private void DisableTaskMngr()
		{
			Microsoft.Win32.RegistryKey regkey;
			string keyValueInt = "1";
			string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
			try
			{
				regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
				regkey.SetValue("DisableTaskMgr", keyValueInt);
				regkey.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		public SuperFile GetScreenshot()
		{
			return Task.Run(() => GettingScreenshot()).Result;
		}

		public SuperFile GettingScreenshot()
		{
			int width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
			int height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
			Bitmap printscreen = new Bitmap(width, height);
			Graphics graphics = Graphics.FromImage(printscreen as System.Drawing.Image);
			graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
			string fname = System.IO.Path.GetTempFileName();
			printscreen.Save(fname);
			SuperFile sf = new SuperFile
			{
				Name = "screen",
				Content = File.ReadAllBytes(fname)
			};
			File.Delete(fname);
			return sf;
		}

		public void SendMessage(string mes)
		{
			Task.Run(() => MessageBox.Show(mes));
		}

		public void Reboot()
		{
			switcher.halt(true, true);
		}

		public void ShutDown()
		{
			switcher.halt(false, true);
		}

		public void Disconnect()
		{
			client1.DeleteClient(PCName);
			Process.GetCurrentProcess().Kill();
		}

		public Process[] GetProcesses()
		{
			return Process.GetProcesses();
		}

		public void CloseProcess(int ProcessId)
		{
			try
			{
				Process.GetProcessById(ProcessId)?.Kill();
			}
			catch { }
		}

		public string[] GetDrives()
		{
			List<string> lst = new List<string>();
			MessageBox.Show(DriveInfo.GetDrives().ToString());
			foreach (var s in DriveInfo.GetDrives()) if (s.DriveType == DriveType.Fixed) lst.Add(s.Name);
			return lst.ToArray();
		}

		public FileInfo[] GetFiles(string path)
		{
			return new DirectoryInfo(path).GetFiles();
		}

		public DirectoryInfo[] GetDirectories(string path)
		{
			return new DirectoryInfo(path).GetDirectories();
		}

		public bool RemoveFile(string path)
		{
			try
			{
				if (System.IO.File.Exists(path))
					File.Delete(path);
				else if (System.IO.Directory.Exists(path))
					Directory.Delete(path, true);
				return true;
			}
			catch { return false; }
		}

		public string[] FindFiles(string mask)
		{
			List<string> files = new List<string>();
			foreach (DriveInfo disk in DriveInfo.GetDrives())
				foreach (string file in Directory.GetFiles(mask, disk.Name, SearchOption.AllDirectories))
					files.Add(file);
			return files.ToArray();
		}


		public SuperFile TakeFile(string path)
		{
			throw new NotImplementedException();
		}

		public void Add_Client(Client cl)
		{

		}

		public void Remove_Client(Client cl)
		{

		}

		public void UpdateClients(Dictionary<string, Client> UsingClients, Dictionary<string, Client> Clients)
		{

		}
	}
}