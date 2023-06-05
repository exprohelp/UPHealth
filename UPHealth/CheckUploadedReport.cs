using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace UPHealth.Reports
{
    public partial class CheckUploadedReport : Telerik.WinControls.UI.RadForm
    {
     
        string _patient_id = string.Empty;
        string _result = string.Empty;
        uph_proxy.UPHealthServicesSoapClient uphproxy = new uph_proxy.UPHealthServicesSoapClient();

        public CheckUploadedReport(string RegNo)
        {
            _patient_id = RegNo;
            InitializeComponent();
        }
        private void CrossCheckForm_Load(object sender, EventArgs e)
        {
            dtRegdate.Value = System.DateTime.Now;
            GlobalUsage.Health_proxy = new uph_proxy.UPHealthServicesSoapClient();
            txtRegNo.Text = _patient_id;
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                DataSet ds = uphproxy.UPHealth_Queries(out _result, GlobalUsage.UnitId, dtRegdate.Value.ToString("yyyy/MM/dd"), dtRegdate.Value.ToString("yyyy/MM/dd"), "0", "HospitalList", GlobalUsage.LoginId);
                ddlHospital.Items.AddRange(GlobalUsage.FillTelrikCombo(ds.Tables[0]));
                ddlHospital.SelectedIndex = 0;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
        private void gridPending_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                byte[] data = GlobalUsage.Health_proxy.DownloadFile(gridPending.CurrentRow.Cells["FilePath"].Value.ToString());
                if (data.Length > 0)
                {
                    //this.radPdfViewer1.UnloadDocument();
                    string path = Application.StartupPath + "\\" + "temp.pdf";
                    File.WriteAllBytes(path, data);
                    axAcroPDF1.src=Application.StartupPath + "\\" + "temp.pdf";
                    //this.radPdfViewer1.LoadDocument(Application.StartupPath + "\\" + "temp.pdf");
                }
                else
                { MessageBox.Show("Report not uploaded"); }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void CheckUploadedReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalUsage.Health_proxy = new uph_proxy.UPHealthServicesSoapClient();
        }
        private void btnLoadPatientDetail_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.Health_proxy.UPHealth_Queries(out _result,ddlHospital.SelectedValue.ToString(),dtRegdate.Value.ToString("yyyy/MM/dd"), "", "1900/01/01","ReportOfDay",GlobalUsage.LoginId);
                dg_patientdetail.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            LoadReport(e.Row.Cells["reg_no"].Value.ToString());
        }

        private void LoadReport(string reg_no)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.Health_proxy.UPHealth_Queries(out _result, "", reg_no, "", "1900/01/01", "GetUploadedReport", GlobalUsage.LoginId);
                gridPending.DataSource = ds.Tables[1];
                dg_testdetail.DataSource = ds.Tables[0];

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            LoadReport(txtRegNo.Text);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.Health_proxy.UPHealth_Queries(out _result, ddlHospital.SelectedValue.ToString(), dtRegdate.Value.ToString("yyyy/MM/dd"), "", txtMobile.Text.Trim(), "SearchByMobile", GlobalUsage.LoginId);
                dg_patientdetail.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }


    }
}
