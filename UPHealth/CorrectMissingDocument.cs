
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
    public partial class CorrectMissingDocument : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty; 
       int scrool_amt = 0;
        int downloadCount = 0;
        string ref_no = string.Empty; string _file_path = string.Empty;
        DataSet _ds = new DataSet();
        ImageList imageList = new ImageList();
        List<string> paperList = new List<string>();
       // public WebKitBrowser browser=new WebKitBrowser();
        Accounts_Proxy.Accounts_WebServiceSoapClient obj = new Accounts_Proxy.Accounts_WebServiceSoapClient();
        uph_proxy.UPHealthServicesSoapClient uphproxy = new uph_proxy.UPHealthServicesSoapClient();
        public CorrectMissingDocument()
        {
            InitializeComponent();
        }
        //[DllImport("user32.dll", SetLastError = true)]
        //private static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);
        //[DllImport("user32.dll", SetLastError = true)]
        //static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private void CurrentInfoFromRoot_Load(object sender, EventArgs e)
        {
             try
            {
                ddldate.SelectedIndex = 0;
                ddldoc.SelectedIndex = 0;
                ddlHospital.SelectedIndex = 0;

                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                DataSet ds = uphproxy.UPHealth_Queries(out _result, GlobalUsage.UnitId, "1900/01/01", "1900/01/01", "0", "HospitalList", GlobalUsage.LoginId);
                ddlHospital.Items.AddRange(GlobalUsage.FillTelrikCombo(ds.Tables[0]));
                ddlHospital.SelectedIndex =0;
                ds = obj.GetQueryResult("execute pGetMissedData '','','','Employee' ","UPHealth");
                ddlEmployee.Items.AddRange(GlobalUsage.FillTelrikCombo(ds.Tables[0]));
                ddlEmployee.SelectedIndex = 0;
      
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            DeleteAll();
        }
        private void DeleteAll()
        {
            try
            {
                foreach (string file_str in Directory.GetFiles(Application.StartupPath + "\\image_data"))
                {
                    File.Delete(file_str);
                }
            }
            catch (Exception ex) { }
        }
      
        private void ShowImage(string ref_no,string path)
        {
            try
            {
                paperList = new List<string>();
                Cursor.Current = Cursors.WaitCursor;
                byte[] data=obj.DownloadFile(path,out _result);
                string path2 = string.Empty;
                if(!Directory.Exists(Application.StartupPath + "\\image_data"))
                    Directory.CreateDirectory(Application.StartupPath + "\\image_data");
                path2 = Application.StartupPath + "\\image_data" + "\\"+ ref_no+".jpeg";
                File.WriteAllBytes(path2, data);
                trackBar1.Value = 25;
                alvImageViewer1.ImageFromFile(path2);
                alvImageViewer1.AutoFitToScreen = false;
                alvImageViewer1.AutoFitToHeight = false;
                alvImageViewer1.AutoFitToWidth = false;
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
     
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //impnl_pif.Zoom = trackBar1.Value * 0.02f;
           
            if (trackBar1.Value == 25)
            alvImageViewer1.ZoomRatio = 1;
            if (trackBar1.Value > scrool_amt)
            {
                if (alvImageViewer1.ZoomRatio < 10)
                {
                    alvImageViewer1.ZoomRatio = ((alvImageViewer1.ZoomRatio * 10) + 1) / 10;
                }
            }
            else
            {
                if (alvImageViewer1.ZoomRatio > 0.1)
                {
                    alvImageViewer1.ZoomRatio = ((alvImageViewer1.ZoomRatio * 10) - 1) / 10;
                }
            }
            scrool_amt = trackBar1.Value;
        }


        private void radButton2_Click(object sender, EventArgs e)
        {
            alvImageViewer1.Rotate90Right();
        }
       private void dg_patientdetail_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            downloadCount = 0;
            ref_no = dg_patientdetail.CurrentRow.Cells["ref_no"].Value.ToString();
            DataSet ds = obj.GetQueryResult("execute pGetMissedData '" + ddlEmployee.SelectedValue.ToString() + "','" + ref_no + "','','SelectedDoc' ", "UPHealth");
            ddldoc.Text=ds.Tables[0].Rows[0]["doc_name"].ToString();
            ddldate.Text=ds.Tables[0].Rows[0]["REG_DATE"].ToString();
            txtBarcode.Text=ds.Tables[0].Rows[0]["barcode"].ToString();
            txtIdNumber.Text=ds.Tables[0].Rows[0]["IDNO"].ToString();
            txtname.Text=ds.Tables[0].Rows[0]["pt_name"].ToString();
            ShowImage(ref_no, dg_patientdetail.CurrentRow.Cells["file_path"].Value.ToString());
        }
        private void printBTN_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            PrintDocument(_file_path);
            Cursor.Current = Cursors.Default;
        }
        private static void PrintDocument(string filePath)
        {
            PrintDocument pd = new PrintDocument();
            //pd.DefaultPageSettings.PrinterSettings.PrinterName = "Printer Name";
            pd.DefaultPageSettings.Landscape = false;
            pd.PrintPage += (sender, args) =>
            {
                Image i = Image.FromFile(filePath);
                Rectangle m = args.MarginBounds;

                if ((double)i.Width / (double)i.Height > (double)m.Width / (double)m.Height) // image is wider
                {
                    m.Height =( (int)((double)i.Height / (double)i.Width * (double)m.Width));
                }
                else
                {
                    m.Width = ((int)((double)i.Width / (double)i.Height * (double)m.Height));
                }
                args.Graphics.DrawImage(i, m);
            };
            pd.Print();
        }

        private void Show_scanDocument_FormClosed(object sender, FormClosedEventArgs e)
        {
            alvImageViewer1.ClearImage();
            alvImageViewer1.Dispose();
        }

      
        private void radButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach(string path in paperList)
            PrintDocument(path);
            Cursor.Current = Cursors.Default;
        }
        private void radButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = obj.GetQueryResult("execute pGetMissedData '" + ddlEmployee.SelectedValue.ToString() + "','','','DocList' ", "UPHealth");
                dg_patientdetail.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    GridViewRowInfo gr = dg_patientdetail.Rows.AddNew();
                    gr.Cells["ref_no"].Value = dr["ref_no"].ToString();
                    gr.Cells["file_path"].Value = dr["file_path"].ToString();
                }
                lblPendong.Text = "Pending : "+dg_patientdetail.Rows.Count.ToString();
             }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string doc_name="";
                string unitid ="";
                string date  ="";

                if (txtBarcode.Text.Trim().Length == 0 && txtIdNumber.Text.Trim().Length==0)
                {
                    doc_name = ddldoc.Text;
                    unitid = ddlHospital.SelectedValue.ToString();
                    date = ddldate.Text;

                    if (date.Contains("Select"))
                    { MessageBox.Show("please select date"); return; }

                    if (unitid.Contains("Select"))
                    { MessageBox.Show("please select unit"); return; }

                    if (txtname.Text.Length < 2)
                    { MessageBox.Show("please input  patient name"); return; }

                    if (doc_name.Length < 2)
                    { MessageBox.Show("please select document name"); return; }

                }
                else
                {
                    doc_name = ddldoc.Text;
                    if (doc_name.Length < 2)
                    { MessageBox.Show("please select document name"); return; }
                }
                string qry = "update DeletedFile set set_flag='Y', doc_name='" + doc_name + "', pt_name='" + txtname.Text + "', unitid='" + unitid + "',idno='" + txtIdNumber.Text + "', barcode='" + txtBarcode.Text + "', login_id='" + GlobalUsage.LoginId + "',reg_date='" + date + "' where  file_name='" + ref_no + "' ";
                string msg = obj.QueryExecute(qry, "UPHealth");
                if (msg.Contains("Success"))
                {
                  
                    dg_patientdetail.CurrentRow.Delete();
                    txtBarcode.Text = "";
                    txtIdNumber.Text = "";
                    txtname.Text = "";
                    ddldate.SelectedIndex = 0;
                    ddlHospital.SelectedIndex = 0;
                }
                else
                { MessageBox.Show(msg); }
                lblPendong.Text = "Pending : " + dg_patientdetail.Rows.Count.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            string qry = "update DeletedFile set set_flag='X',login_id='" + GlobalUsage.LoginId + "' where file_name='" + ref_no + "' ";
            string msg = obj.QueryExecute(qry, "UPHealth");
            if (msg.Contains("Success"))
            {
                dg_patientdetail.CurrentRow.Delete();
                txtBarcode.Text = "";
            }
            else
            { MessageBox.Show(msg); }
            lblPendong.Text = "Pending : " + dg_patientdetail.Rows.Count.ToString();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            string qry = "update DeletedFile set set_flag='K',login_id='" + GlobalUsage.LoginId + "' where file_name='" + ref_no + "' ";
            string msg = obj.QueryExecute(qry, "UPHealth");
            if (msg.Contains("Success"))
            {
                dg_patientdetail.CurrentRow.Delete();
                txtBarcode.Text = "";
            }
            else
            { MessageBox.Show(msg); }
            lblPendong.Text = "Pending : " + dg_patientdetail.Rows.Count.ToString();
        }



    }
}
