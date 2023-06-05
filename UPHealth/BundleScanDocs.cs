
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WebKit;

namespace UPHealth
{
    public partial class BundleScanDocs : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty; 
        int scrool_amt = 0;
        int downloadCount = 0;
        string ref_no = string.Empty; string _file_path = string.Empty;
        string regdate = string.Empty;
        string pt_name = string.Empty;
        DataSet _ds = new DataSet();
        ImageList imageList = new ImageList();
        int _Index = 0;
        int totalcount = 0;
        int sentcount = 0;
        List<string> paperList = new List<string>();
        Accounts_Proxy.Accounts_WebServiceSoapClient obj = new Accounts_Proxy.Accounts_WebServiceSoapClient();
        uph_proxy.UPHealthServicesSoapClient uphproxy = new uph_proxy.UPHealthServicesSoapClient();
        public BundleScanDocs()
        {
            InitializeComponent();
        }
        private void btnLoadPatientDetail_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.Health_proxy.UPHealth_Queries(out _result, ddlHospital.SelectedValue.ToString(), dtFrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"), "1900/01/01", "ScanDocDetail2", GlobalUsage.LoginId);
                dg_patientdetail.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd=new FolderBrowserDialog();
            fbd.ShowDialog();
            txtPath.Text = fbd.SelectedPath;
        }
        private void btnStartPackaging_Click(object sender, EventArgs e)
        {
            _Index = 0;
            sentcount = 0;
            ref_no = string.Empty;
            totalcount = dg_patientdetail.Rows.Count;
            ref_no  =dg_patientdetail.Rows[_Index].Cells["ref_no"].Value.ToString();
            pt_name =dg_patientdetail.Rows[_Index].Cells["pt_name"].Value.ToString();
            
            if(!backgroundWorker1.IsBusy)
            {
              backgroundWorker1.RunWorkerAsync();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ShowImage(ref_no);
        }
        private void ShowImage(string ref_no)
        {
            try
            {
                paperList = new List<string>();
                Cursor.Current = Cursors.WaitCursor;
                byte[][] imageList = GlobalUsage.Health_proxy.UPHealth_GetMultipleImages(ref_no, GlobalUsage.LoginId);
                // alvImageViewer1.ClearImage();
                if (imageList.Length > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    //if (imageList[0] != null)
                     //   AddOneByOneDownloadedImage(ref_no, "PIF", imageList[0]);
                    if (imageList[1] != null)
                        AddOneByOneDownloadedImage(ref_no, "PRC_1", imageList[1]);
                    if (imageList[2] != null)
                        AddOneByOneDownloadedImage(ref_no, "PRC_2", imageList[2]);
                    if (imageList[3] != null)
                        AddOneByOneDownloadedImage(ref_no, "IDCard", imageList[3]);
                }
            }
            catch (Exception ex) {}
            finally { Cursor.Current = Cursors.Default; }
        }
        private void AddOneByOneDownloadedImage(string ref_no, string doc_name, byte[] data)
        {
            try
            {
                string path = string.Empty;
                //string dir = txtPath.Text + "\\" + ddlHospital.SelectedValue.ToString() + "_" + dtFrom.Value.ToString("ddMMyyyy");
                string dir = txtPath.Text + "\\" + ddlHospital.SelectedValue.ToString() + "_" + regdate;
                if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
                path = dir + "\\" + pt_name+"["+ref_no+"]"+ "-" + doc_name + ".jpeg";
                System.IO.File.WriteAllBytes(path, data);
            }
            catch (Exception ex) { }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (sentcount < totalcount - 1)
            {
                _Index++;
                sentcount++;
                dg_patientdetail.Rows[_Index - 1].Cells["p_flag"].Value = "Y";
                txtsAtatus.Text = totalcount + " / " + (sentcount + 1) + " [" + ((sentcount + 1) * 100 / totalcount) + " % ]";
                
                ref_no  = dg_patientdetail.Rows[_Index].Cells["ref_no"].Value.ToString();
                pt_name = dg_patientdetail.Rows[_Index].Cells["pt_name"].Value.ToString();
                regdate = dg_patientdetail.Rows[_Index].Cells["regdate"].Value.ToString(); 
                if(!backgroundWorker1.IsBusy)
                {
                  backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("Successfully Sent");

            }
        }

        private void BundleScanDocs_Load(object sender, EventArgs e)
        {
            dtFrom.Value = System.DateTime.Now;
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                DataSet ds = uphproxy.UPHealth_Queries(out _result, GlobalUsage.UnitId, dtFrom.Value.ToString("yyyy/MM/dd"), dtFrom.Value.ToString("yyyy/MM/dd"), "0", "HospitalList", GlobalUsage.LoginId);
                ddlHospital.Items.AddRange(GlobalUsage.FillTelrikCombo(ds.Tables[0]));
                ddlHospital.SelectedIndex = 0;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dg_patientdetail_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["p_flag"].Value.ToString() == "Y")
                e.RowElement.ForeColor=Color.Green;
            else
                e.RowElement.ForeColor=Color.Black;
        }





    }
}
