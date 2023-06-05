using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace UPHealth
{
    public partial class AutoUpdater : Form
    {
       
        public AutoUpdater()
        {
            InitializeComponent();
        }
        private void cmdDownload_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = Application.StartupPath + "\\AutoUpdater\\ExProAutoUpdater.exe";
            string args = GlobalUsage.LoginId.Trim() + " " + Application.ProductName.Trim() + " " + GlobalUsage.UnitId.Trim() + " " + Application.ProductVersion.Trim() + " " + Environment.MachineName.ToString();
            p.StartInfo.Arguments = args;
            p.Start();
            Application.Exit();
        }
      
    }
}
