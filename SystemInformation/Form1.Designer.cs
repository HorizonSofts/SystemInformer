namespace SystemInformation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TextSystem = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SystemCpu = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TextDrive = new System.Windows.Forms.RichTextBox();
            this.More = new System.Windows.Forms.TabPage();
            this.BtnShow = new System.Windows.Forms.Button();
            this.TextMore = new System.Windows.Forms.RichTextBox();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.More.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.More);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(5, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 459);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TextSystem);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(345, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "System";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TextSystem
            // 
            this.TextSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextSystem.Location = new System.Drawing.Point(3, 3);
            this.TextSystem.Name = "TextSystem";
            this.TextSystem.ReadOnly = true;
            this.TextSystem.Size = new System.Drawing.Size(339, 427);
            this.TextSystem.TabIndex = 0;
            this.TextSystem.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SystemCpu);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(345, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CPU";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SystemCpu
            // 
            this.SystemCpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemCpu.Location = new System.Drawing.Point(3, 3);
            this.SystemCpu.Name = "SystemCpu";
            this.SystemCpu.ReadOnly = true;
            this.SystemCpu.Size = new System.Drawing.Size(339, 427);
            this.SystemCpu.TabIndex = 0;
            this.SystemCpu.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TextDrive);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(345, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Drives";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TextDrive
            // 
            this.TextDrive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextDrive.Location = new System.Drawing.Point(3, 3);
            this.TextDrive.Name = "TextDrive";
            this.TextDrive.ReadOnly = true;
            this.TextDrive.Size = new System.Drawing.Size(339, 427);
            this.TextDrive.TabIndex = 0;
            this.TextDrive.Text = "";
            // 
            // More
            // 
            this.More.Controls.Add(this.BtnShow);
            this.More.Controls.Add(this.TextMore);
            this.More.Controls.Add(this.comboClass);
            this.More.Location = new System.Drawing.Point(4, 22);
            this.More.Name = "More";
            this.More.Padding = new System.Windows.Forms.Padding(3);
            this.More.Size = new System.Drawing.Size(345, 433);
            this.More.TabIndex = 3;
            this.More.Text = "More";
            this.More.UseVisualStyleBackColor = true;
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(251, 12);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(88, 23);
            this.BtnShow.TabIndex = 3;
            this.BtnShow.Text = "Show Details";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Visible = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // TextMore
            // 
            this.TextMore.Location = new System.Drawing.Point(6, 41);
            this.TextMore.Name = "TextMore";
            this.TextMore.ReadOnly = true;
            this.TextMore.Size = new System.Drawing.Size(333, 390);
            this.TextMore.TabIndex = 2;
            this.TextMore.Text = "";
            // 
            // comboClass
            // 
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Items.AddRange(new object[] {
            "Win32_1394Controller",
            "Win32_1394ControllerDevice",
            "Win32_AccountSID",
            "Win32_ActionCheck",
            "Win32_ActiveRoute",
            "Win32_AllocatedResource",
            "Win32_ApplicationCommandLine",
            "Win32_ApplicationService",
            "Win32_AssociatedBattery",
            "Win32_AssociatedProcessorMemory",
            "Win32_AutochkSetting",
            "Win32_BaseBoard",
            "Win32_Battery",
            "Win32_Binary",
            "Win32_BindImageAction",
            "Win32_BIOS",
            "Win32_BootConfiguration",
            "Win32_Bus Win32_CacheMemory",
            "Win32_CDROMDrive",
            "Win32_CheckCheck",
            "Win32_CIMLogicalDeviceCIMDataFile",
            "Win32_ClassicCOMApplicationClasses",
            "Win32_ClassicCOMClass",
            "Win32_ClassicCOMClassSetting",
            "Win32_ClassicCOMClassSettings",
            "Win32_ClassInforAction",
            "Win32_ClientApplicationSetting",
            "Win32_CodecFile",
            "Win32_COMApplicationSettings",
            "Win32_COMClassAutoEmulator",
            "Win32_ComClassEmulator",
            "Win32_CommandLineAccess",
            "Win32_ComponentCategory",
            "Win32_ComputerSystem",
            "Win32_ComputerSystemProcessor",
            "Win32_ComputerSystemProduct",
            "Win32_ComputerSystemWindowsProductActivationSetting",
            "Win32_Condition",
            "Win32_ConnectionShare",
            "Win32_ControllerHastHub",
            "Win32_CreateFolderAction",
            "Win32_CurrentProbe",
            "Win32_DCOMApplication",
            "Win32_DCOMApplicationAccessAllowedSetting",
            "Win32_DCOMApplicationLaunchAllowedSetting",
            "Win32_DCOMApplicationSetting",
            "Win32_DependentService",
            "Win32_Desktop",
            "Win32_DesktopMonitor",
            "Win32_DeviceBus",
            "Win32_DeviceMemoryAddress",
            "Win32_Directory",
            "Win32_DirectorySpecification",
            "Win32_DiskDrive",
            "Win32_DiskDrivePhysicalMedia",
            "Win32_DiskDriveToDiskPartition",
            "Win32_DiskPartition",
            "Win32_DiskQuota",
            "Win32_DisplayConfiguration",
            "Win32_DisplayControllerConfiguration",
            "Win32_DMAChanner",
            "Win32_DriverForDevice",
            "Win32_DriverVXD",
            "Win32_DuplicateFileAction",
            "Win32_Environment",
            "Win32_EnvironmentSpecification",
            "Win32_ExtensionInfoAction",
            "Win32_Fan",
            "Win32_FileSpecification",
            "Win32_FloppyController",
            "Win32_FloppyDrive",
            "Win32_FontInfoAction",
            "Win32_Group",
            "Win32_GroupDomain",
            "Win32_GroupUser",
            "Win32_HeatPipe",
            "Win32_IDEController",
            "Win32_IDEControllerDevice",
            "Win32_ImplementedCategory",
            "Win32_InfraredDevice",
            "Win32_IniFileSpecification",
            "Win32_InstalledSoftwareElement",
            "Win32_IP4PersistedRouteTable",
            "Win32_IP4RouteTable",
            "Win32_IRQResource",
            "Win32_Keyboard",
            "Win32_LaunchCondition",
            "Win32_LoadOrderGroup",
            "Win32_LoadOrderGroupServiceDependencies",
            "Win32_LoadOrderGroupServiceMembers",
            "Win32_LocalTime",
            "Win32_LoggedOnUser",
            "Win32_LogicalDisk",
            "Win32_LogicalDiskRootDirectory",
            "Win32_LogicalDiskToPartition",
            "Win32_LogicalFileAccess",
            "Win32_LogicalFileAuditing",
            "Win32_LogicalFileGroup",
            "Win32_LogicalFileOwner",
            "Win32_LogicalFileSecuritySetting",
            "Win32_LogicalMemoryConfiguration",
            "Win32_LogicalProgramGroup",
            "Win32_LogicalProgramGroupDirectory",
            "Win32_LogicalProgramGroupItem",
            "Win32_LogicalProgramGroupItemDataFile",
            "Win32_LogicalShareAccess",
            "Win32_LogicalShareAuditing",
            "Win32_LogicalShareSecuritySetting",
            "Win32_LogonSession",
            "Win32_LogonSessionMappedDisk",
            "Win32_MappedLogicalDisk",
            "Win32_MemoryArray",
            "Win32_MemoryArrayLocation",
            "Win32_MemoryDevice",
            "Win32_MemoryDeviceArray",
            "Win32_MemoryDeviceLocation",
            "Win32_MIMEInfoAction",
            "Win32_MotherboardDevice",
            "Win32_MoveFileAction",
            "Win32_NamedJobObject",
            "Win32_NamedJobObjectActgInfo",
            "Win32_NamedJobObjectLimit",
            "Win32_NamedJobObjectLimitSetting",
            "Win32_NamedJobObjectProcess",
            "Win32_NamedJobObjectSecLimit",
            "Win32_NamedJobObjectSecLimitSetting",
            "Win32_NamedJobObjectStatistics",
            "Win32_NetworkAdapter",
            "Win32_NetworkAdapterConfiguration",
            "Win32_NetworkAdapterSetting",
            "Win32_NetworkClient",
            "Win32_NetworkConnection",
            "Win32_NetworkLoginProfile",
            "Win32_NetworkProtocol",
            "Win32_NTDomain",
            "Win32_NTEventlogFile",
            "Win32_NTLogEvent",
            "Win32_NTLogEventComputer",
            "Win32_NTLogEvnetLog",
            "Win32_NTLogEventUser",
            "Win32_ODBCAttribute",
            "Win32_ODBCDataSourceAttribute",
            "Win32_ODBCDataSourceSpecification",
            "Win32_ODBCDriverAttribute",
            "Win32_ODBCDriverSoftwareElement",
            "Win32_ODBCDriverSpecification",
            "Win32_ODBCSourceAttribute",
            "Win32_ODBCTranslatorSpecification",
            "Win32_OnBoardDevice",
            "Win32_OperatingSystem",
            "Win32_OperatingSystemAutochkSetting",
            "Win32_OperatingSystemQFE",
            "Win32_OSRecoveryConfiguración",
            "Win32_PageFile",
            "Win32_PageFileElementSetting",
            "Win32_PageFileSetting",
            "Win32_PageFileUsage",
            "Win32_ParallelPort",
            "Win32_Patch",
            "Win32_PatchFile",
            "Win32_PatchPackage",
            "Win32_PCMCIAControler",
            "Win32_PerfFormattedData_ASP_ActiveServerPages",
            "Win32_PerfFormattedData_ASPNET_114322_ASPNETAppsv114322",
            "Win32_PerfFormattedData_ASPNET_114322_ASPNETv114322",
            "Win32_PerfFormattedData_ASPNET_2040607_ASPNETAppsv2040607",
            "Win32_PerfFormattedData_ASPNET_2040607_ASPNETv2040607",
            "Win32_PerfFormattedData_ASPNET_ASPNET",
            "Win32_PerfFormattedData_ASPNET_ASPNETApplications",
            "Win32_PerfFormattedData_aspnet_state_ASPNETStateService",
            "Win32_PerfFormattedData_ContentFilter_IndexingServiceFilter",
            "Win32_PerfFormattedData_ContentIndex_IndexingService",
            "Win32_PerfFormattedData_DTSPipeline_SQLServerDTSPipeline",
            "Win32_PerfFormattedData_Fax_FaxServices",
            "Win32_PerfFormattedData_InetInfo_InternetInformationServicesGlobal",
            "Win32_PerfFormattedData_ISAPISearch_HttpIndexingService",
            "Win32_PerfFormattedData_MSDTC_DistributedTransactionCoordinator",
            "Win32_PerfFormattedData_NETCLRData_NETCLRData",
            "Win32_PerfFormattedData_NETCLRNetworking_NETCLRNetworking",
            "Win32_PerfFormattedData_NETDataProviderforOracle_NETCLRData",
            "Win32_PerfFormattedData_NETDataProviderforSqlServer_NETDataProviderforSqlServer",
            "Win32_PerfFormattedData_NETFramework_NETCLRExceptions",
            "Win32_PerfFormattedData_NETFramework_NETCLRInterop",
            "Win32_PerfFormattedData_NETFramework_NETCLRJit",
            "Win32_PerfFormattedData_NETFramework_NETCLRLoading",
            "Win32_PerfFormattedData_NETFramework_NETCLRLocksAndThreads",
            "Win32_PerfFormattedData_NETFramework_NETCLRMemory",
            "Win32_PerfFormattedData_NETFramework_NETCLRRemoting",
            "Win32_PerfFormattedData_NETFramework_NETCLRSecurity",
            "Win32_PerfFormattedData_NTFSDRV_ControladordealmacenamientoNTFSdeSMTP",
            "Win32_PerfFormattedData_Outlook_Outlook",
            "Win32_PerfFormattedData_PerfDisk_LogicalDisk",
            "Win32_PerfFormattedData_PerfDisk_PhysicalDisk",
            "Win32_PerfFormattedData_PerfNet_Browser",
            "Win32_PerfFormattedData_PerfNet_Redirector",
            "Win32_PerfFormattedData_PerfNet_Server",
            "Win32_PerfFormattedData_PerfNet_ServerWorkQueues",
            "Win32_PerfFormattedData_PerfOS_Cache",
            "Win32_PerfFormattedData_PerfOS_Memory",
            "Win32_PerfFormattedData_PerfOS_Objects",
            "Win32_PerfFormattedData_PerfOS_PagingFile",
            "Win32_PerfFormattedData_PerfOS_Processor",
            "Win32_PerfFormattedData_PerfOS_System",
            "Win32_PerfFormattedData_PerfProc_FullImage_Costly",
            "Win32_PerfFormattedData_PerfProc_Image_Costly",
            "Win32_PerfFormattedData_PerfProc_JobObject",
            "Win32_PerfFormattedData_PerfProc_JobObjectDetails",
            "Win32_PerfFormattedData_PerfProc_Process",
            "Win32_PerfFormattedData_PerfProc_ProcessAddressSpace_Costly",
            "Win32_PerfFormattedData_PerfProc_Thread",
            "Win32_PerfFormattedData_PerfProc_ThreadDetails_Costly",
            "Win32_PerfFormattedData_RemoteAccess_RASPort",
            "Win32_PerfFormattedData_RemoteAccess_RASTotal",
            "Win32_PerfFormattedData_RSVP_RSVPInterfaces",
            "Win32_PerfFormattedData_RSVP_RSVPService",
            "Win32_PerfFormattedData_Spooler_PrintQueue",
            "Win32_PerfFormattedData_TapiSrv_Telephony",
            "Win32_PerfFormattedData_Tcpip_ICMP",
            "Win32_PerfFormattedData_Tcpip_IP",
            "Win32_PerfFormattedData_Tcpip_NBTConnection",
            "Win32_PerfFormattedData_Tcpip_NetworkInterface",
            "Win32_PerfFormattedData_Tcpip_TCP",
            "Win32_PerfFormattedData_Tcpip_UDP",
            "Win32_PerfFormattedData_TermService_TerminalServices",
            "Win32_PerfFormattedData_TermService_TerminalServicesSession",
            "Win32_PerfFormattedData_W3SVC_WebService",
            "Win32_PerfRawData_ASP_ActiveServerPages",
            "Win32_PerfRawData_ASPNET_114322_ASPNETAppsv114322",
            "Win32_PerfRawData_ASPNET_114322_ASPNETv114322",
            "Win32_PerfRawData_ASPNET_2040607_ASPNETAppsv2040607",
            "Win32_PerfRawData_ASPNET_2040607_ASPNETv2040607",
            "Win32_PerfRawData_ASPNET_ASPNET",
            "Win32_PerfRawData_ASPNET_ASPNETApplications",
            "Win32_PerfRawData_aspnet_state_ASPNETStateService",
            "Win32_PerfRawData_ContentFilter_IndexingServiceFilter",
            "Win32_PerfRawData_ContentIndex_IndexingService",
            "Win32_PerfRawData_DTSPipeline_SQLServerDTSPipeline",
            "Win32_PerfRawData_Fax_FaxServices",
            "Win32_PerfRawData_InetInfo_InternetInformationServicesGlobal",
            "Win32_PerfRawData_ISAPISearch_HttpIndexingService",
            "Win32_PerfRawData_MSDTC_DistributedTransactionCoordinator",
            "Win32_PerfRawData_NETCLRData_NETCLRData",
            "Win32_PerfRawData_NETCLRNetworking_NETCLRNetworking",
            "Win32_PerfRawData_NETDataProviderforOracle_NETCLRData",
            "Win32_PerfRawData_NETDataProviderforSqlServer_NETDataProviderforSqlServer",
            "Win32_PerfRawData_NETFramework_NETCLRExceptions",
            "Win32_PerfRawData_NETFramework_NETCLRInterop",
            "Win32_PerfRawData_NETFramework_NETCLRJit",
            "Win32_PerfRawData_NETFramework_NETCLRLoading",
            "Win32_PerfRawData_NETFramework_NETCLRLocksAndThreads",
            "Win32_PerfRawData_NETFramework_NETCLRMemory",
            "Win32_PerfRawData_NETFramework_NETCLRRemoting",
            "Win32_PerfRawData_NETFramework_NETCLRSecurity",
            "Win32_PerfRawData_NTFSDRV_ControladordealmacenamientoNTFSdeSMTP",
            "Win32_PerfRawData_Outlook_Outlook",
            "Win32_PerfRawData_PerfDisk_LogicalDisk",
            "Win32_PerfRawData_PerfDisk_PhysicalDisk",
            "Win32_PerfRawData_PerfNet_Browser",
            "Win32_PerfRawData_PerfNet_Redirector",
            "Win32_PerfRawData_PerfNet_Server",
            "Win32_PerfRawData_PerfNet_ServerWorkQueues",
            "Win32_PerfRawData_PerfOS_Cache",
            "Win32_PerfRawData_PerfOS_Memory",
            "Win32_PerfRawData_PerfOS_Objects",
            "Win32_PerfRawData_PerfOS_PagingFile",
            "Win32_PerfRawData_PerfOS_Processor",
            "Win32_PerfRawData_PerfOS_System",
            "Win32_PerfRawData_PerfProc_FullImage_Costly",
            "Win32_PerfRawData_PerfProc_Image_Costly",
            "Win32_PerfRawData_PerfProc_JobObject",
            "Win32_PerfRawData_PerfProc_JobObjectDetails",
            "Win32_PerfRawData_PerfProc_Process",
            "Win32_PerfRawData_PerfProc_ProcessAddressSpace_Costly",
            "Win32_PerfRawData_PerfProc_Thread",
            "Win32_PerfRawData_PerfProc_ThreadDetails_Costly",
            "Win32_PerfRawData_RemoteAccess_RASPort",
            "Win32_PerfRawData_RemoteAccess_RASTotal",
            "Win32_PerfRawData_RSVP_RSVPInterfaces",
            "Win32_PerfRawData_RSVP_RSVPService",
            "Win32_PerfRawData_Spooler_PrintQueue",
            "Win32_PerfRawData_TapiSrv_Telephony",
            "Win32_PerfRawData_Tcpip_ICMP",
            "Win32_PerfRawData_Tcpip_IP",
            "Win32_PerfRawData_Tcpip_NBTConnection",
            "Win32_PerfRawData_Tcpip_NetworkInterface",
            "Win32_PerfRawData_Tcpip_TCP",
            "Win32_PerfRawData_Tcpip_UDP",
            "Win32_PerfRawData_TermService_TerminalServices",
            "Win32_PerfRawData_TermService_TerminalServicesSession",
            "Win32_PerfRawData_W3SVC_WebService",
            "Win32_PhysicalMedia",
            "Win32_PhysicalMemory",
            "Win32_PhysicalMemoryArray",
            "Win32_PhysicalMemoryLocation",
            "Win32_PingStatus",
            "Win32_PNPAllocatedResource",
            "Win32_PnPDevice",
            "Win32_PnPEntity",
            "Win32_PnPSignedDriver",
            "Win32_PnPSignedDriverCIMDataFile",
            "Win32_PointingDevice",
            "Win32_PortableBattery",
            "Win32_PortConnector",
            "Win32_PortResource",
            "Win32_POTSModem",
            "Win32_POTSModemToSerialPort",
            "Win32_Printer",
            "Win32_PrinterConfiguration",
            "Win32_PrinterController",
            "Win32_PrinterDriver",
            "Win32_PrinterDriverDll",
            "Win32_PrinterSetting",
            "Win32_PrinterShare",
            "Win32_PrintJob",
            "Win32_Process",
            "Win32_Processor",
            "Win32_Product",
            "Win32_ProductCheck",
            "Win32_ProductResource",
            "Win32_ProductSoftwareFeatures",
            "Win32_ProgIDSpecification",
            "Win32_ProgramGroup",
            "Win32_ProgramGroupContents",
            "Win32_Property",
            "Win32_ProtocolBinding",
            "Win32_Proxy",
            "Win32_PublishComponentAction",
            "Win32_QuickFixEngineering",
            "Win32_QuotaSetting",
            "Win32_Refrigeration",
            "Win32_Registry",
            "Win32_RegistryAction",
            "Win32_RemoveFileAction",
            "Win32_RemoveIniAction",
            "Win32_ReserveCost",
            "Win32_ScheduledJob",
            "Win32_SCSIController",
            "Win32_SCSIControllerDevice",
            "Win32_SecuritySettingOfLogicalFile",
            "Win32_SecuritySettingOfLogicalShare",
            "Win32_SelfRegModuleAction",
            "Win32_SerialPort",
            "Win32_SerialPortConfiguration",
            "Win32_SerialPortSetting",
            "Win32_ServerConnection",
            "Win32_ServerSession",
            "Win32_Service",
            "Win32_ServiceControl",
            "Win32_ServiceSpecification",
            "Win32_ServiceSpecificationService",
            "Win32_SessionConnection",
            "Win32_SessionProcess",
            "Win32_Share",
            "Win32_ShareToDirectory",
            "Win32_ShortcutAction",
            "Win32_ShortcutFile",
            "Win32_ShortcutSAP",
            "Win32_SID",
            "Win32_SoftwareElement",
            "Win32_SoftwareElementAction",
            "Win32_SoftwareElementCheck",
            "Win32_SoftwareElementCondition",
            "Win32_SoftwareElementResource",
            "Win32_SoftwareFeature",
            "Win32_SoftwareFeatureAction",
            "Win32_SoftwareFeatureCheck",
            "Win32_SoftwareFeatureParent",
            "Win32_SoftwareFeatureSoftwareElements",
            "Win32_SoundDevice",
            "Win32_StartupCommand",
            "Win32_SubDirectory",
            "Win32_SystemAccount",
            "Win32_SystemBIOS",
            "Win32_SystemBootConfiguration",
            "Win32_SystemDesktop",
            "Win32_SystemDevices",
            "Win32_SystemDriver",
            "Win32_SystemDriverPNPEntity",
            "Win32_SystemEnclosure",
            "Win32_SystemLoadOrderGroups",
            "Win32_SystemLogicalMemoryConfiguration",
            "Win32_SystemNetworkConnections",
            "Win32_SystemOperatingSystem",
            "Win32_SystemPartitions",
            "Win32_SystemProcesses",
            "Win32_SystemProgramGroups",
            "Win32_SystemResources",
            "Win32_SystemServices",
            "Win32_SystemSlot",
            "Win32_SystemSystemDriver",
            "Win32_SystemTimeZone",
            "Win32_SystemUsers",
            "Win32_TapeDrive",
            "Win32_TCPIPPrinterPort",
            "Win32_TemperatureProbe",
            "Win32_Terminal",
            "Win32_TerminalService",
            "Win32_TerminalServiceSetting",
            "Win32_TerminalServiceToSetting",
            "Win32_TerminalTerminalSetting",
            "Win32_Thread",
            "Win32_TimeZone",
            "Win32_TSAccount",
            "Win32_TSClientSetting",
            "Win32_TSEnvironmentSetting",
            "Win32_TSGeneralSetting",
            "Win32_TSLogonSetting",
            "Win32_TSNetworkAdapterListSetting",
            "Win32_TSNetworkAdapterSetting",
            "Win32_TSPermissionsSetting",
            "Win32_TSRemoteControlSetting",
            "Win32_TSSessionDirectory",
            "Win32_TSSessionDirectorySetting",
            "Win32_TSSessionSetting",
            "Win32_TypeLibraryAction",
            "Win32_UninterruptiblePowerSupply",
            "Win32_USBController",
            "Win32_USBControllerDevice",
            "Win32_USBHub",
            "Win32_UserAccount",
            "Win32_UserDesktop",
            "Win32_UserInDomain",
            "Win32_UTCTime",
            "Win32_VideoController",
            "Win32_VideoSettings",
            "Win32_VoltageProbe",
            "Win32_VolumeQuotaSetting",
            "Win32_WindowsProductActivation",
            "Win32_WMIElementSetting",
            "Win32_WMISetting"});
            this.comboClass.Location = new System.Drawing.Point(8, 12);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(237, 21);
            this.comboClass.TabIndex = 0;
            this.comboClass.Text = "------------------------Select a Class-------------------------";
            this.comboClass.SelectedIndexChanged += new System.EventHandler(this.comboClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version : 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "OpenSource tool By : ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(114, 519);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "HorizonSofts";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(345, 433);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name : System Informer";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 94);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(336, 333);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Version : 1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Developer : Hammad Maqbool";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Company : HorizonSofts";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(147, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "System Informer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Version : 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 536);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Informer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.More.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox TextSystem;
        private System.Windows.Forms.RichTextBox SystemCpu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox TextDrive;
        private System.Windows.Forms.TabPage More;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.RichTextBox TextMore;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

    }
}

