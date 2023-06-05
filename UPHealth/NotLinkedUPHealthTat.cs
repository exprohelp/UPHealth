using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI.Export;
using System.Linq;
namespace UPHealth
{
    public partial class NotLinkedUPHealthTat : Telerik.WinControls.UI.RadForm
    {
        uph_proxy.UPHealthServicesSoapClient uphproxy = new uph_proxy.UPHealthServicesSoapClient();
        string[] remarks = {"Sample is hemolyzed","Sample Clot", "Sample has less quantity" };
        int delaycount = 0;
        public NotLinkedUPHealthTat()
        {
            InitializeComponent();
        }

        private void btnOpenPat_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                DataSet ds = uphproxy.UPHealth_Queries(out _result,"",dtFrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"),"", "NotLinked", GlobalUsage.LoginId);
                dgTAT.DataSource = ds.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void NotLinkedUPHealthTat_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
            if (GlobalUsage.LoginId.ToUpper() == "CHCL-02895")
            { radGroupBox1.Enabled = true; }
            else
            { radGroupBox1.Enabled = false; }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadWronglyLinked();
        }

        private void LoadWronglyLinked()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                DataSet ds = uphproxy.UPHealth_Queries(out _result, "", dtFrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"), "", "MultipleLink", GlobalUsage.LoginId);
                rgv_patientcount.DataSource = ds.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void rgv_patientcount_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete ?", "Confirmation", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string _result = string.Empty;
                   _result= uphproxy.EstablishLink(rgv_patientcount.CurrentRow.Cells["PUID"].Value.ToString(),"",GlobalUsage.LoginId,"DeleteLink");
                    MessageBox.Show(_result);
                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
          
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                _result = uphproxy.EstablishLink(txtPUID.Text,txtUPHCode.Text, GlobalUsage.LoginId, "Update");
                MessageBox.Show(_result);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
         
        }
    }
}
