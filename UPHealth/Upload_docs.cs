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
    public partial class Upload_docs : Telerik.WinControls.UI.RadForm
    {
       
        public Upload_docs()
        {
            InitializeComponent();
        }

        private void btn_pif_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an image file to encrypt.";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Encrypt the selected file. I'll do this later. :)
            }         
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //DataSet ds=new DataSet();
            //ds.ReadXml(Application.StartupPath+"\\XMLFile1.xml");
            //StringWriter sw = new StringWriter();
            //ds.WriteXml(sw);
            //uph_proxy.UPHChandanHealthServiceSoapClient obj=new uph_proxy.UPHChandanHealthServiceSoapClient();
            //string str=  obj.PushPatientData(sw.ToString());
            //MessageBox.Show(str);
        
        }

    }
}
