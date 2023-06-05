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
    public partial class UPHealthTat : Telerik.WinControls.UI.RadForm
    {
        uph_proxy.UPHealthServicesSoapClient uphproxy = new uph_proxy.UPHealthServicesSoapClient();
        string[] remarks = {"Sample is hemolyzed","Sample Clot", "Sample has less quantity" };
        int delaycount = 0;
        public UPHealthTat()
        {
            InitializeComponent();
        }
        private void PopulateRemarks()
        {
          
      
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                DataSet ds = uphproxy.UPHealth_Queries(out _result,GlobalUsage.UnitId,dtFrom.Value.ToString("yyyy/MM/dd"),dtTo.Value.ToString("yyyy/MM/dd"),txtHour.Text, "HospitalList", GlobalUsage.LoginId);
                ddlHospital.Items.AddRange(GlobalUsage.FillTelrikCombo(ds.Tables[0]));
                ddlHospital.SelectedIndex = 0;
                Cursor.Current = Cursors.Default;
                ddlLab.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    
       private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
           

                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                DataSet ds = uphproxy.UPHealth_Queries(out _result, GlobalUsage.UnitId, dtFrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"),txtHour.Text, "Split_TATRegister", GlobalUsage.LoginId);
                dgTAT.DataSource = ds.Tables[0];
                 Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void UPHealthTat_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
            PopulateRemarks();

        }
        string _reg_no = string.Empty;
        string _uphealthcode = string.Empty;
        private void dgFilterList_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["RSLT"].Value.ToString() == "TNP")
                e.RowElement.ForeColor = Color.Red;
            else
                e.RowElement.ForeColor = Color.Black;
        }
        private void MasterTemplate_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if(e.RowElement.RowInfo.Cells["delay"].Value.ToString()=="Y")
            e.RowElement.ForeColor = Color.Red;
            else
            e.RowElement.ForeColor = Color.Black;
        }

        private void btnOpenPat_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                DataSet ds = uphproxy.UPHealth_Queries(out _result, ddlHospital.SelectedValue.ToString(), dtFrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"), ddlLab.Text, "TatRegister", GlobalUsage.LoginId);
                dgTAT.DataSource = ds.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
