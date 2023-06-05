using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace UPHealth
{
    public partial class TestList : Telerik.WinControls.UI.RadForm
    {
        public TestList()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string _result = string.Empty;
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.Health_proxy.UPHealth_Queries(out _result, GlobalUsage.UnitId,"", "", "1900/01/01", "TestList", GlobalUsage.LoginId);
                ds.WriteXml("d:\\testlist.xml");
                dgTestList.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void TestList_Load(object sender, EventArgs e)
        {
            if(File.Exists("d:\\testlist.xml"))
            {
                DataSet ds = new DataSet();
                ds.ReadXml("d:\\testlist.xml");
                dgTestList.DataSource = ds.Tables[0];
            }
        }
    }
}
