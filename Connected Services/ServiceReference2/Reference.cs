﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RNA_Client.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Client", Namespace="http://schemas.datacontract.org/2004/07/RNA_Rebuild")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Net.IPAddress))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Net.Sockets.AddressFamily))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ushort[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client>))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(string[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.Dictionary<string, string>))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(RNA_Client.ServiceReference2.SuperFile))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.IO.DirectoryInfo[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.IO.DirectoryInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.IO.FileSystemInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.IO.FileInfo[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.IO.FileInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Diagnostics.Process[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Diagnostics.Process))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Diagnostics.ProcessPriorityClass))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Diagnostics.ProcessStartInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Diagnostics.ProcessWindowStyle))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.ComponentModel.Component))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.MarshalByRefObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.IntPtr))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Security.SecureString))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Text.Encoding))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Text.DecoderFallback))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Text.EncoderFallback))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(RNA_Client.ServiceReference2.CodePageDataItem))]
    public partial class Client : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object CallbackField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ConnectionTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Net.IPAddress IPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PcNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Callback {
            get {
                return this.CallbackField;
            }
            set {
                if ((object.ReferenceEquals(this.CallbackField, value) != true)) {
                    this.CallbackField = value;
                    this.RaisePropertyChanged("Callback");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ConnectionTime {
            get {
                return this.ConnectionTimeField;
            }
            set {
                if ((this.ConnectionTimeField.Equals(value) != true)) {
                    this.ConnectionTimeField = value;
                    this.RaisePropertyChanged("ConnectionTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Net.IPAddress IP {
            get {
                return this.IPField;
            }
            set {
                if ((object.ReferenceEquals(this.IPField, value) != true)) {
                    this.IPField = value;
                    this.RaisePropertyChanged("IP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PcName {
            get {
                return this.PcNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PcNameField, value) != true)) {
                    this.PcNameField = value;
                    this.RaisePropertyChanged("PcName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SuperFile", Namespace="http://schemas.datacontract.org/2004/07/RNA_Rebuild")]
    [System.SerializableAttribute()]
    public partial class SuperFile : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CodePageDataItem", Namespace="http://schemas.datacontract.org/2004/07/System.Globalization")]
    [System.SerializableAttribute()]
    public partial class CodePageDataItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string m_bodyNameField;
        
        private int m_dataIndexField;
        
        private uint m_flagsField;
        
        private string m_headerNameField;
        
        private int m_uiFamilyCodePageField;
        
        private string m_webNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string m_bodyName {
            get {
                return this.m_bodyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.m_bodyNameField, value) != true)) {
                    this.m_bodyNameField = value;
                    this.RaisePropertyChanged("m_bodyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int m_dataIndex {
            get {
                return this.m_dataIndexField;
            }
            set {
                if ((this.m_dataIndexField.Equals(value) != true)) {
                    this.m_dataIndexField = value;
                    this.RaisePropertyChanged("m_dataIndex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public uint m_flags {
            get {
                return this.m_flagsField;
            }
            set {
                if ((this.m_flagsField.Equals(value) != true)) {
                    this.m_flagsField = value;
                    this.RaisePropertyChanged("m_flags");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string m_headerName {
            get {
                return this.m_headerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.m_headerNameField, value) != true)) {
                    this.m_headerNameField = value;
                    this.RaisePropertyChanged("m_headerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int m_uiFamilyCodePage {
            get {
                return this.m_uiFamilyCodePageField;
            }
            set {
                if ((this.m_uiFamilyCodePageField.Equals(value) != true)) {
                    this.m_uiFamilyCodePageField = value;
                    this.RaisePropertyChanged("m_uiFamilyCodePage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string m_webName {
            get {
                return this.m_webNameField;
            }
            set {
                if ((object.ReferenceEquals(this.m_webNameField, value) != true)) {
                    this.m_webNameField = value;
                    this.RaisePropertyChanged("m_webName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1", CallbackContract=typeof(RNA_Client.ServiceReference2.IService1Callback))]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddClient", ReplyAction="http://tempuri.org/IService1/AddClientResponse")]
        bool AddClient(string NewPcName, System.Net.IPAddress NewIP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddClient", ReplyAction="http://tempuri.org/IService1/AddClientResponse")]
        System.Threading.Tasks.Task<bool> AddClientAsync(string NewPcName, System.Net.IPAddress NewIP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddAdmin", ReplyAction="http://tempuri.org/IService1/AddAdminResponse")]
        void AddAdmin(string PC_Name, System.Net.IPAddress IP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddAdmin", ReplyAction="http://tempuri.org/IService1/AddAdminResponse")]
        System.Threading.Tasks.Task AddAdminAsync(string PC_Name, System.Net.IPAddress IP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAdmin", ReplyAction="http://tempuri.org/IService1/DeleteAdminResponse")]
        void DeleteAdmin(string PC_Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAdmin", ReplyAction="http://tempuri.org/IService1/DeleteAdminResponse")]
        System.Threading.Tasks.Task DeleteAdminAsync(string PC_Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetScreenShot", ReplyAction="http://tempuri.org/IService1/GetScreenShotResponse")]
        RNA_Client.ServiceReference2.SuperFile GetScreenShot(RNA_Client.ServiceReference2.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetScreenShot", ReplyAction="http://tempuri.org/IService1/GetScreenShotResponse")]
        System.Threading.Tasks.Task<RNA_Client.ServiceReference2.SuperFile> GetScreenShotAsync(RNA_Client.ServiceReference2.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DisconnectClient", ReplyAction="http://tempuri.org/IService1/DisconnectClientResponse")]
        void DisconnectClient(string PC_Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DisconnectClient", ReplyAction="http://tempuri.org/IService1/DisconnectClientResponse")]
        System.Threading.Tasks.Task DisconnectClientAsync(string PC_Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteClient", ReplyAction="http://tempuri.org/IService1/DeleteClientResponse")]
        void DeleteClient(string PCName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteClient", ReplyAction="http://tempuri.org/IService1/DeleteClientResponse")]
        System.Threading.Tasks.Task DeleteClientAsync(string PCName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetActiveClients", ReplyAction="http://tempuri.org/IService1/SetActiveClientsResponse")]
        void SetActiveClients(System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client> Clients);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetActiveClients", ReplyAction="http://tempuri.org/IService1/SetActiveClientsResponse")]
        System.Threading.Tasks.Task SetActiveClientsAsync(System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client> Clients);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClients", ReplyAction="http://tempuri.org/IService1/GetClientsResponse")]
        System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client> GetClients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClients", ReplyAction="http://tempuri.org/IService1/GetClientsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client>> GetClientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetActiveClients", ReplyAction="http://tempuri.org/IService1/GetActiveClientsResponse")]
        System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client> GetActiveClients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetActiveClients", ReplyAction="http://tempuri.org/IService1/GetActiveClientsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client>> GetActiveClientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClient", ReplyAction="http://tempuri.org/IService1/GetClientResponse")]
        RNA_Client.ServiceReference2.Client GetClient(string PCname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClient", ReplyAction="http://tempuri.org/IService1/GetClientResponse")]
        System.Threading.Tasks.Task<RNA_Client.ServiceReference2.Client> GetClientAsync(string PCname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUsingClient", ReplyAction="http://tempuri.org/IService1/AddUsingClientResponse")]
        void AddUsingClient(string PCname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUsingClient", ReplyAction="http://tempuri.org/IService1/AddUsingClientResponse")]
        System.Threading.Tasks.Task AddUsingClientAsync(string PCname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUsingClient", ReplyAction="http://tempuri.org/IService1/DeleteUsingClientResponse")]
        void DeleteUsingClient(string PCname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUsingClient", ReplyAction="http://tempuri.org/IService1/DeleteUsingClientResponse")]
        System.Threading.Tasks.Task DeleteUsingClientAsync(string PCname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetSMTPClient", ReplyAction="http://tempuri.org/IService1/SetSMTPClientResponse")]
        void SetSMTPClient(string server, int port, string address, string password, bool ssl, string reciever);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetSMTPClient", ReplyAction="http://tempuri.org/IService1/SetSMTPClientResponse")]
        System.Threading.Tasks.Task SetSMTPClientAsync(string server, int port, string address, string password, bool ssl, string reciever);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChangeSMTPLogging", ReplyAction="http://tempuri.org/IService1/ChangeSMTPLoggingResponse")]
        void ChangeSMTPLogging(bool value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChangeSMTPLogging", ReplyAction="http://tempuri.org/IService1/ChangeSMTPLoggingResponse")]
        System.Threading.Tasks.Task ChangeSMTPLoggingAsync(bool value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChangeTXTLogging", ReplyAction="http://tempuri.org/IService1/ChangeTXTLoggingResponse")]
        void ChangeTXTLogging(bool value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChangeTXTLogging", ReplyAction="http://tempuri.org/IService1/ChangeTXTLoggingResponse")]
        System.Threading.Tasks.Task ChangeTXTLoggingAsync(bool value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShutdownPCs", ReplyAction="http://tempuri.org/IService1/ShutdownPCsResponse")]
        void ShutdownPCs(RNA_Client.ServiceReference2.Client Client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShutdownPCs", ReplyAction="http://tempuri.org/IService1/ShutdownPCsResponse")]
        System.Threading.Tasks.Task ShutdownPCsAsync(RNA_Client.ServiceReference2.Client Client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RebootPCs", ReplyAction="http://tempuri.org/IService1/RebootPCsResponse")]
        void RebootPCs(RNA_Client.ServiceReference2.Client Client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RebootPCs", ReplyAction="http://tempuri.org/IService1/RebootPCsResponse")]
        System.Threading.Tasks.Task RebootPCsAsync(RNA_Client.ServiceReference2.Client Client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckMail", ReplyAction="http://tempuri.org/IService1/CheckMailResponse")]
        bool CheckMail();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckMail", ReplyAction="http://tempuri.org/IService1/CheckMailResponse")]
        System.Threading.Tasks.Task<bool> CheckMailAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClientDrives", ReplyAction="http://tempuri.org/IService1/GetClientDrivesResponse")]
        string[] GetClientDrives(RNA_Client.ServiceReference2.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClientDrives", ReplyAction="http://tempuri.org/IService1/GetClientDrivesResponse")]
        System.Threading.Tasks.Task<string[]> GetClientDrivesAsync(RNA_Client.ServiceReference2.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClientDirectories", ReplyAction="http://tempuri.org/IService1/GetClientDirectoriesResponse")]
        System.IO.DirectoryInfo[] GetClientDirectories(RNA_Client.ServiceReference2.Client client, string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClientDirectories", ReplyAction="http://tempuri.org/IService1/GetClientDirectoriesResponse")]
        System.Threading.Tasks.Task<System.IO.DirectoryInfo[]> GetClientDirectoriesAsync(RNA_Client.ServiceReference2.Client client, string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClientFiles", ReplyAction="http://tempuri.org/IService1/GetClientFilesResponse")]
        System.IO.FileInfo[] GetClientFiles(RNA_Client.ServiceReference2.Client client, string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClientFiles", ReplyAction="http://tempuri.org/IService1/GetClientFilesResponse")]
        System.Threading.Tasks.Task<System.IO.FileInfo[]> GetClientFilesAsync(RNA_Client.ServiceReference2.Client client, string path);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Callback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetScreenshot", ReplyAction="http://tempuri.org/IService1/GetScreenshotResponse")]
        RNA_Client.ServiceReference2.SuperFile GetScreenshot();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService1/SendMessage")]
        void SendMessage(string mes);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService1/Reboot")]
        void Reboot();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService1/ShutDown")]
        void ShutDown();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService1/Disconnect")]
        void Disconnect();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProcesses", ReplyAction="http://tempuri.org/IService1/GetProcessesResponse")]
        System.Diagnostics.Process[] GetProcesses();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService1/CloseProcess")]
        void CloseProcess(int ProcessId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDrives", ReplyAction="http://tempuri.org/IService1/GetDrivesResponse")]
        string[] GetDrives();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFiles", ReplyAction="http://tempuri.org/IService1/GetFilesResponse")]
        System.IO.FileInfo[] GetFiles(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDirectories", ReplyAction="http://tempuri.org/IService1/GetDirectoriesResponse")]
        System.IO.DirectoryInfo[] GetDirectories(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RemoveFile", ReplyAction="http://tempuri.org/IService1/RemoveFileResponse")]
        bool RemoveFile(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindFiles", ReplyAction="http://tempuri.org/IService1/FindFilesResponse")]
        string[] FindFiles(string mask);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TakeFile", ReplyAction="http://tempuri.org/IService1/TakeFileResponse")]
        RNA_Client.ServiceReference2.SuperFile TakeFile(string path);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService1/Add_Client")]
        void Add_Client(RNA_Client.ServiceReference2.Client cl);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService1/Remove_Client")]
        void Remove_Client(RNA_Client.ServiceReference2.Client cl);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService1/UpdateClients")]
        void UpdateClients(System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client> UsingClients, System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client> Clients);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : RNA_Client.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.DuplexClientBase<RNA_Client.ServiceReference2.IService1>, RNA_Client.ServiceReference2.IService1 {
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public bool AddClient(string NewPcName, System.Net.IPAddress NewIP) {
            return base.Channel.AddClient(NewPcName, NewIP);
        }
        
        public System.Threading.Tasks.Task<bool> AddClientAsync(string NewPcName, System.Net.IPAddress NewIP) {
            return base.Channel.AddClientAsync(NewPcName, NewIP);
        }
        
        public void AddAdmin(string PC_Name, System.Net.IPAddress IP) {
            base.Channel.AddAdmin(PC_Name, IP);
        }
        
        public System.Threading.Tasks.Task AddAdminAsync(string PC_Name, System.Net.IPAddress IP) {
            return base.Channel.AddAdminAsync(PC_Name, IP);
        }
        
        public void DeleteAdmin(string PC_Name) {
            base.Channel.DeleteAdmin(PC_Name);
        }
        
        public System.Threading.Tasks.Task DeleteAdminAsync(string PC_Name) {
            return base.Channel.DeleteAdminAsync(PC_Name);
        }
        
        public RNA_Client.ServiceReference2.SuperFile GetScreenShot(RNA_Client.ServiceReference2.Client client) {
            return base.Channel.GetScreenShot(client);
        }
        
        public System.Threading.Tasks.Task<RNA_Client.ServiceReference2.SuperFile> GetScreenShotAsync(RNA_Client.ServiceReference2.Client client) {
            return base.Channel.GetScreenShotAsync(client);
        }
        
        public void DisconnectClient(string PC_Name) {
            base.Channel.DisconnectClient(PC_Name);
        }
        
        public System.Threading.Tasks.Task DisconnectClientAsync(string PC_Name) {
            return base.Channel.DisconnectClientAsync(PC_Name);
        }
        
        public void DeleteClient(string PCName) {
            base.Channel.DeleteClient(PCName);
        }
        
        public System.Threading.Tasks.Task DeleteClientAsync(string PCName) {
            return base.Channel.DeleteClientAsync(PCName);
        }
        
        public void SetActiveClients(System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client> Clients) {
            base.Channel.SetActiveClients(Clients);
        }
        
        public System.Threading.Tasks.Task SetActiveClientsAsync(System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client> Clients) {
            return base.Channel.SetActiveClientsAsync(Clients);
        }
        
        public System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client> GetClients() {
            return base.Channel.GetClients();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client>> GetClientsAsync() {
            return base.Channel.GetClientsAsync();
        }
        
        public System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client> GetActiveClients() {
            return base.Channel.GetActiveClients();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, RNA_Client.ServiceReference2.Client>> GetActiveClientsAsync() {
            return base.Channel.GetActiveClientsAsync();
        }
        
        public RNA_Client.ServiceReference2.Client GetClient(string PCname) {
            return base.Channel.GetClient(PCname);
        }
        
        public System.Threading.Tasks.Task<RNA_Client.ServiceReference2.Client> GetClientAsync(string PCname) {
            return base.Channel.GetClientAsync(PCname);
        }
        
        public void AddUsingClient(string PCname) {
            base.Channel.AddUsingClient(PCname);
        }
        
        public System.Threading.Tasks.Task AddUsingClientAsync(string PCname) {
            return base.Channel.AddUsingClientAsync(PCname);
        }
        
        public void DeleteUsingClient(string PCname) {
            base.Channel.DeleteUsingClient(PCname);
        }
        
        public System.Threading.Tasks.Task DeleteUsingClientAsync(string PCname) {
            return base.Channel.DeleteUsingClientAsync(PCname);
        }
        
        public void SetSMTPClient(string server, int port, string address, string password, bool ssl, string reciever) {
            base.Channel.SetSMTPClient(server, port, address, password, ssl, reciever);
        }
        
        public System.Threading.Tasks.Task SetSMTPClientAsync(string server, int port, string address, string password, bool ssl, string reciever) {
            return base.Channel.SetSMTPClientAsync(server, port, address, password, ssl, reciever);
        }
        
        public void ChangeSMTPLogging(bool value) {
            base.Channel.ChangeSMTPLogging(value);
        }
        
        public System.Threading.Tasks.Task ChangeSMTPLoggingAsync(bool value) {
            return base.Channel.ChangeSMTPLoggingAsync(value);
        }
        
        public void ChangeTXTLogging(bool value) {
            base.Channel.ChangeTXTLogging(value);
        }
        
        public System.Threading.Tasks.Task ChangeTXTLoggingAsync(bool value) {
            return base.Channel.ChangeTXTLoggingAsync(value);
        }
        
        public void ShutdownPCs(RNA_Client.ServiceReference2.Client Client) {
            base.Channel.ShutdownPCs(Client);
        }
        
        public System.Threading.Tasks.Task ShutdownPCsAsync(RNA_Client.ServiceReference2.Client Client) {
            return base.Channel.ShutdownPCsAsync(Client);
        }
        
        public void RebootPCs(RNA_Client.ServiceReference2.Client Client) {
            base.Channel.RebootPCs(Client);
        }
        
        public System.Threading.Tasks.Task RebootPCsAsync(RNA_Client.ServiceReference2.Client Client) {
            return base.Channel.RebootPCsAsync(Client);
        }
        
        public bool CheckMail() {
            return base.Channel.CheckMail();
        }
        
        public System.Threading.Tasks.Task<bool> CheckMailAsync() {
            return base.Channel.CheckMailAsync();
        }
        
        public string[] GetClientDrives(RNA_Client.ServiceReference2.Client client) {
            return base.Channel.GetClientDrives(client);
        }
        
        public System.Threading.Tasks.Task<string[]> GetClientDrivesAsync(RNA_Client.ServiceReference2.Client client) {
            return base.Channel.GetClientDrivesAsync(client);
        }
        
        public System.IO.DirectoryInfo[] GetClientDirectories(RNA_Client.ServiceReference2.Client client, string path) {
            return base.Channel.GetClientDirectories(client, path);
        }
        
        public System.Threading.Tasks.Task<System.IO.DirectoryInfo[]> GetClientDirectoriesAsync(RNA_Client.ServiceReference2.Client client, string path) {
            return base.Channel.GetClientDirectoriesAsync(client, path);
        }
        
        public System.IO.FileInfo[] GetClientFiles(RNA_Client.ServiceReference2.Client client, string path) {
            return base.Channel.GetClientFiles(client, path);
        }
        
        public System.Threading.Tasks.Task<System.IO.FileInfo[]> GetClientFilesAsync(RNA_Client.ServiceReference2.Client client, string path) {
            return base.Channel.GetClientFilesAsync(client, path);
        }
    }
}