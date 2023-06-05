
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
    public partial class SearchPatientInDocument : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty; 
       int scrool_amt = 0;
        int downloadCount = 0;
        string ref_no = string.Empty; string _file_path = string.Empty;
        DataSet _ds = new DataSet();
        ImageList imageList = new ImageList();
       // public WebKitBrowser browser=new WebKitBrowser();
        Accounts_Proxy.Accounts_WebServiceSoapClient obj = new Accounts_Proxy.Accounts_WebServiceSoapClient();
        uph_proxy.UPHealthServicesSoapClient uphproxy = new uph_proxy.UPHealthServicesSoapClient();
        public SearchPatientInDocument()
        {
            InitializeComponent();
        }
        //[DllImport("user32.dll", SetLastError = true)]
        //private static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);
        //[DllImport("user32.dll", SetLastError = true)]
        //static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private void CurrentInfoFromRoot_Load(object sender, EventArgs e)
        {
            dtRegdate.Value = System.DateTime.Now;
            DeleteAll();
            GlobalUsage.Health_proxy = new uph_proxy.UPHealthServicesSoapClient();
            GlobalUsage.accounts_proxy = new Accounts_Proxy.Accounts_WebServiceSoapClient();
            //splitPanel7.Controls.Add(browser);
            //browser.Dock = DockStyle.Fill;
            dtRegdate.Value = DateTime.Today;
            //browser.Navigate("http://pdis.uphssp.org/");
            ////Process p = Process.Start("http://pdis.uphssp.org/");
            ////Thread.Sleep(500); // Allow the process to open it's window
            ////SetParent(p.MainWindowHandle,splitPanel3.Handle);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                DataSet ds = uphproxy.UPHealth_Queries(out _result, GlobalUsage.UnitId, dtRegdate.Value.ToString("yyyy/MM/dd"), dtRegdate.Value.ToString("yyyy/MM/dd"), "0", "HospitalList", GlobalUsage.LoginId);
                ddlHospital.Items.AddRange(GlobalUsage.FillTelrikCombo(ds.Tables[0]));
                ddlHospital.SelectedIndex =0;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
			
        }
        private void DeleteAll()
        {
            foreach (string file_str in Directory.GetFiles(Application.StartupPath + "\\image_data"))
            {
                File.Delete(file_str);
            }
        }
        private void AddOneByOneDownloadedImage(string ref_no, string doc_name, byte[] data)
        {
            string path = string.Empty;
            if (!Directory.Exists(Application.StartupPath + "\\image_data"))
                Directory.CreateDirectory(Application.StartupPath + "\\image_data");
            path = Application.StartupPath + "\\image_data" + "\\" + ref_no + "-" + doc_name + ".jpeg";
            if (!System.IO.File.Exists(path))
                System.IO.File.WriteAllBytes(path, data);
            FileInfo fi = new FileInfo(path);

            imageList.ImageSize = new Size(120, 100);
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            try
            {
                if (data.Length > 0)
                    imageList.Images.Add(Bitmap.FromFile(fi.FullName).GetThumbnailImage(95, 75, null, IntPtr.Zero));
                else
                    imageList.Images.Add(Bitmap.FromFile(Application.StartupPath + "\\no_image.jpeg").GetThumbnailImage(95, 75, null, IntPtr.Zero));
                
                string name = fi.Name.Replace(fi.Extension, "");
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
            trackBar1.Value = 25;
            _file_path = Application.StartupPath + "\\image_data" + "\\" +imageName;
            alvImageViewer1.ImageFromFile(_file_path);
            alvImageViewer1.AutoFitToScreen = false;
            alvImageViewer1.AutoFitToHeight = false;
            alvImageViewer1.AutoFitToWidth = false;
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

        private void radButton2_Click(object sender, EventArgs e)
        {
            alvImageViewer1.Rotate90Right();
        }

        private void btnLoadPatientDetail_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.Health_proxy.UPHealth_Queries(out _result, ddlHospital.SelectedValue.ToString(), dtRegdate.Value.ToString("yyyy/MM/dd"), "", "1900/01/01", "GET_PIF", GlobalUsage.LoginId);
                dg_patientdetail.DataSource = ds.Tables[0];
                
                loadAllPif();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void loadAllPif()
        {
            imageList = new ImageList();
            lvTileImages.Items.Clear();
            foreach (GridViewRowInfo gr in dg_patientdetail.Rows)
            {
                byte[] data = GlobalUsage.Health_proxy.DownloadFile(gr.Cells["doc_location"].Value.ToString());
                AddOneByOneDownloadedImage(gr.Cells["ref_no"].Value.ToString(),"PIF",data);
            }
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




    }
}
