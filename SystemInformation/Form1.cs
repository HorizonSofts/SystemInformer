using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SystemInformation
{
    public partial class Form1 : Form
    {
        DeviceInformation devinfo = new DeviceInformation();
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            TextSystem.Text = devinfo.DeviceInfo();
            SystemCpu.Text = devinfo.DeviceInformation1("Win32_Processor");
            TextDrive.Text = devinfo.DeviceInformation1("Win32_LogicalDisk");
        }

        private void comboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnShow.Visible = true;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            TextMore.Text = devinfo.DeviceInformation1(comboClass.SelectedItem.ToString());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
