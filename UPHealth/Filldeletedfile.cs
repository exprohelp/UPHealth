using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace UPHealth
{
    public partial class Filldeletedfile : Form
    {
        Accounts_Proxy.Accounts_WebServiceSoapClient obj = new Accounts_Proxy.Accounts_WebServiceSoapClient();
        string dir = "";
        public Filldeletedfile()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            radButton1.Enabled = false;
            dir = radTextBox1.Text;
            backgroundWorker1.RunWorkerAsync();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string[] files = Directory.GetFiles(dir);
                foreach (string f in files)
                {
                    FileInfo fi = new FileInfo(f);
                    string name = fi.Name.Split('.')[0];
                    string qry = "insert into DeletedFile(file_name,file_path) values('" + name + "','" + f + "') ";
                    obj.QueryExecute(qry, "UPHealth");
                }
                MessageBox.Show("Done");
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
