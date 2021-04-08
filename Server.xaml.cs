using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RNA_Client
{
	/// <summary>
	/// Interaction logic for Server.xaml
	/// </summary>
	/// 
	public delegate void ApplyIpPort(IPAddress IP, int Port);
	public partial class Server : Window
	{
		public event ApplyIpPort ApplyingIpPort;
		public Server()
		{
			InitializeComponent();
		}

	}
}
