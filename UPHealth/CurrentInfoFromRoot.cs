
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WebKit;
using CefSharp;
using CefSharp.WinForms;
namespace UPHealth
{
    public partial class CurrentInfoFromRoot : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty; 
        int scrool_amt = 0;
        int downloadCount = 0;
        string ref_no = string.Empty;
        DataSet _ds = new DataSet();
        string _input_date = string.Empty;
        bool allow_pageselection=true;
        string SelectedHospital = string.Empty;
        string _hosp_id = string.Empty;
        ImageList imageList = new ImageList();
        public ChromiumWebBrowser browser = new ChromiumWebBrowser();
     
        Accounts_Proxy.Accounts_WebServiceSoapClient obj = new Accounts_Proxy.Accounts_WebServiceSoapClient();
        public CurrentInfoFromRoot()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private void CurrentInfoFromRoot_Load(object sender, EventArgs e)
        {
            DeleteAll();
            GlobalUsage.Health_proxy = new uph_proxy.UPHealthServicesSoapClient();
            GlobalUsage.accounts_proxy = new Accounts_Proxy.Accounts_WebServiceSoapClient();

            //rpv_Firozabad.Controls.Add(browser_firozabad);
            //browser_firozabad.Dock = DockStyle.Fill;
            //browser_firozabad.Navigate("http://pdis.uphssp.org.in/");

            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("http://192.168.0.21/chandan/design/");
            rpv_Firozabad.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                DataSet ds = GlobalUsage.Health_proxy.UPHealth_Queries(out _result, GlobalUsage.UnitId, "1900/01/01", "1900/01/01", "0", "HospitalList", GlobalUsage.LoginId);
                ddlHospital.Items.AddRange(GlobalUsage.FillTelrikCombo(ds.Tables[0]));
                ddlHospital.SelectedIndex = 0;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           
      
           
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
        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            downloadCount = 0;
            lvTileImages.Items.Clear();
            imageList = new ImageList();
            ref_no = rgv_info.CurrentRow.Cells["ref_no"].Value.ToString();
            allow_pageselection = true;
            if (rgv_info.CurrentRow.Cells["unit_name"].Value.ToString().Contains("Sri. Ram"))
            {
                SelectedHospital = "SriRam";
                radPageView1.SelectedPage = radPageView1.Pages[1];
            }
            else if (rgv_info.CurrentRow.Cells["unit_name"].Value.ToString().Contains("Firozabad"))
            {
                SelectedHospital = "Firozabad";
                radPageView1.SelectedPage = radPageView1.Pages[0];
            }
            ShowImage(ref_no);
        }
        private void ShowImage(string ref_no)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                byte[][] imageList= GlobalUsage.Health_proxy.UPHealth_GetMultipleImages(ref_no,GlobalUsage.LoginId);
               // alvImageViewer1.ClearImage();
                if (imageList.Length>0)
                {
                      Cursor.Current = Cursors.WaitCursor;
                      if (imageList[0] != null)
                      AddOneByOneDownloadedImage(ref_no,"PIF", imageList[0]);
                      if (imageList[1] != null)
                      AddOneByOneDownloadedImage(ref_no, "PRC_1", imageList[1]);
                      if (imageList[2] != null)
                      AddOneByOneDownloadedImage(ref_no, "PRC_2", imageList[2]);
                      if (imageList[3] != null)
                      AddOneByOneDownloadedImage(ref_no, "IDCard", imageList[3]);
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void AddOneByOneDownloadedImage(string ref_no, string doc_name, byte[] data)
        {
         
            string path = string.Empty;
            if(!Directory.Exists(Application.StartupPath + "\\image_data"))
            Directory.CreateDirectory(Application.StartupPath + "\\image_data");
            path = Application.StartupPath + "\\image_data" + "\\" + ref_no + "-" + doc_name + ".jpeg";
            if(!System.IO.File.Exists(path))
            {
              System.IO.File.WriteAllBytes(path, data);
            }
            FileInfo fi = new FileInfo(path);
                imageList.ImageSize = new Size(120, 100);
                imageList.ColorDepth = ColorDepth.Depth32Bit;
                try
                {
                    if(data.Length>0)
                    imageList.Images.Add(Bitmap.FromFile(fi.FullName).GetThumbnailImage(95, 75, null, IntPtr.Zero));
                    else
                    imageList.Images.Add(Bitmap.FromFile(Application.StartupPath + "\\no_image.jpeg").GetThumbnailImage(95, 75, null, IntPtr.Zero));
                    
                    string name = ref_no + "-" + doc_name;// fi.Name.Replace(fi.Extension, "");
                    lvTileImages.Items.Add(name);
                    lvTileImages.TileSize = new System.Drawing.Size(100, 80);

                    this.lvTileImages.Items[downloadCount].ImageIndex = downloadCount;
                    this.lvTileImages.View = View.LargeIcon;
                    this.lvTileImages.LargeImageList = imageList;
                    downloadCount++;

                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

        }
        private void DisplaySeletedTile(string imageName)
        {
            try
            {
                trackBar1.Value = 25;
                string file_path = Application.StartupPath + "\\image_data" + "\\" + ref_no + "-" + imageName.Split('-')[1];
                alvImageViewer1.ImageFromFile(file_path);
                alvImageViewer1.AutoFitToScreen = false;
                alvImageViewer1.AutoFitToHeight = false;
                alvImageViewer1.AutoFitToWidth = false;
            }
            catch (Exception ex) { }
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

        private void lvTileImages_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            DisplaySeletedTile(e.Item.Text + ".jpeg");
        }

        private void btnCollaps_Click(object sender, EventArgs e)
        {
            if (btnCollaps.Text == "C")
            {
                radSplitContainer1.SplitPanels[0].Collapsed = true;
                btnCollaps.Text = "E";
            }
            else
            {
                radSplitContainer1.SplitPanels[0].Collapsed = false;
                btnCollaps.Text = "C";
            }

        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_PDIS_reg.Text.Trim().Length > 0 && ref_no.Length > 2)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _result = GlobalUsage.Health_proxy.EstablishLink(ref_no, txt_PDIS_reg.Text, GlobalUsage.LoginId, "MakeLink");
                    if (_result.Contains("Success"))
                    {
                        GridViewRowInfo row_selected = rgv_info.Rows.AsEnumerable().Where(x => x.Cells["ref_no"].Value.ToString() == ref_no).First();
                        row_selected.Delete();
                        lvTileImages.Items.Clear();
                        txt_PDIS_reg.Text = string.Empty;
                        ref_no = string.Empty;
                        MessageBox.Show(_result);
                    }
                    Cursor.Current = Cursors.Default;

                }
                else
                { MessageBox.Show("Put PDIS Patient Code and select the scan number"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
             pic_image.Visible = true;
            _hosp_id=ddlHospital.SelectedValue.ToString();
            _input_date=dtFrom.Value.ToString("yyyy/MM/dd");
            timer1.Enabled=true;
            timer1.Start();
            if(!backgroundWorker1.IsBusy)
            backgroundWorker1.RunWorkerAsync();
        }
        private void radButton2_Click(object sender, EventArgs e)
        {
            alvImageViewer1.Rotate90Right();
        }
        private void radButton3_Click(object sender, EventArgs e)
        {
            if (radButton3.Text == "Expand")
            {
                radSplitContainer1.SplitPanels[0].Collapsed = true;
                radSplitContainer1.SplitPanels[1].Collapsed = true;
                radButton3.Text = "Collapse";
            }
            else
            {
                radSplitContainer1.SplitPanels[0].Collapsed = false;
                radSplitContainer1.SplitPanels[1].Collapsed = false;
                radButton3.Text = "Expand";
            }
        }
        private void radButton4_Click(object sender, EventArgs e)
        {
         
          
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            if (rgv_info.CurrentRow.Cells["unit_name"].Value.ToString().Contains("Sri Ram"))
            {
                
            }
            else if (rgv_info.CurrentRow.Cells["unit_name"].Value.ToString().Contains("Firozabad"))
            {
                
            }
        

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval =60000;
            if (!backgroundWorker1.IsBusy)
            {
                pic_image.Visible = true;
                timer1.Stop();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void radPageView1_SelectedPageChanging(object sender, RadPageViewCancelEventArgs e)
        {
         
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            if(SelectedHospital == "SriRam" && radPageView1.SelectedPage.Text.Contains("Firozabad"))
            {
                radPageView1.SelectedPage = radPageView1.Pages[1];
            }
            else if (SelectedHospital == "Firozabad" && radPageView1.SelectedPage.Text.Contains("Sri"))
            {
                radPageView1.SelectedPage = radPageView1.Pages[0];
            }
            MessageBox.Show("Manual Selection is not possible");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _ds = GlobalUsage.Health_proxy.UPHealth_Queries(out _result, GlobalUsage.UnitId, _hosp_id, _input_date, "N/A", "GetFeeds", GlobalUsage.LoginId);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                pic_image.Visible = false;
                rgv_info.Rows.Clear();
                foreach (DataRow dr in _ds.Tables[0].Rows)
                {
                    GridViewRowInfo row = rgv_info.Rows.NewRow();
                    row.Cells["PUID"].Value = dr["PUID"].ToString();
                    row.Cells["ref_no"].Value = dr["ref_no"].ToString();
                    row.Cells["unit_name"].Value = dr["unit_name"].ToString();
                    rgv_info.Rows.Add(row);
                }
         
            }
            catch (Exception ex) { }
            finally { timer1.Start(); }
        }
        private void CurrentInfoFromRoot_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                foreach (string file_str in Directory.GetFiles(Application.StartupPath + "\\image_data"))
                {
                    File.Delete(file_str);
                }
            }
            catch (Exception ex) { }
            finally { }
        }
        private void lvTileImages_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                string doc_name = lvTileImages.Items[lvTileImages.FocusedItem.Index].SubItems[0].Text;
                if (MessageBox.Show("Are you sure to delete  " + doc_name + " ", "Confirmation", MessageBoxButtons.YesNo).ToString() == "Yes")
                {
                     string qry = "delete from Patient_ScanedDoc where ref_no+'-'+doc_name='" + doc_name + "' and patient_code is null ";
                    _result=GlobalUsage.accounts_proxy.QueryExecute(qry, "UPHealth");
                    if(_result.Contains("Success"))
                    {
                        lvTileImages.Items[lvTileImages.FocusedItem.Index].Remove();
                        //File.Delete(Application.StartupPath + "\\image_data\\" + doc_name+".jpeg");
                    }
                    else
                    MessageBox.Show(_result);
                }
            }
        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            PeendingWork obj = new PeendingWork(_hosp_id,dtFrom.Value.ToString("yyyy/MM/dd"));
            obj.Owner = this;
            obj.Show();
        }
      }
}
