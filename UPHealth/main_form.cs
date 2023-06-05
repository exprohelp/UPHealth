using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UPHealth
{
    public partial class main_form : Telerik.WinControls.UI.RadRibbonForm
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void ribbonTab1_Click(object sender, EventArgs e)
        {

        }

        private void rb_new_entry_Click(object sender, EventArgs e)
        {
            CurrentInfoFromRoot obj = new CurrentInfoFromRoot();
            obj.Owner = this;
            obj.Show();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            GlobalUsage.Health_proxy = new uph_proxy.UPHealthServicesSoapClient();
            GlobalUsage.cws = new diagProxy.Diagnostic_CS_WebServiceSoapClient();
            this.Text = "UPHealth Ver. " + Application.ProductVersion.ToString();
        }

        private void rb_download_Click(object sender, EventArgs e)
        {
            UPHealth.Reports.CheckUploadedReport obj = new UPHealth.Reports.CheckUploadedReport("");
            obj.Owner = this;
            obj.Show();
        }

        private void rbtn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                DataSet ds = GlobalUsage.Health_proxy.UPHealth_Queries(out _result, GlobalUsage.UnitId, txtLogin_Id.Text,txtpsw.Text, "", "LoginInfo", GlobalUsage.LoginId);
                radRibbonBar1.Enabled = false;
                if (ds.Tables.Count>0 && ds.Tables[0].Rows.Count>0)
                {
                    radRibbonBar1.Enabled = true;
                    GlobalUsage.UnitId = ds.Tables[0].Rows[0]["UID"].ToString();
                    GlobalUsage.LoginId = txtLogin_Id.Text;
                    radLabelElement1.Text = ds.Tables[0].Rows[0]["emp_name"].ToString();
                    Loginbox.Visible = false;
                    if (GlobalUsage.UnitId == "SLAB")
                    {
                        btnNotLinked.Enabled = true;
                        rb_new_entry.Enabled = true;
                    }
                    else
                    {
                        btnNotLinked.Enabled = false;
                        rb_new_entry.Enabled = false;
                    }
                    //string macName = System.Configuration.ConfigurationManager.AppSettings["MacName"].ToString();
                    //if (macName.ToUpper() == "LIS")
                    //{
                    //    string macLeft = System.Configuration.ConfigurationManager.AppSettings["Left"].ToString();
                    //    positionWindowLeft(macLeft + ":" + GlobalUsage.Login_id, PanelLeft);
                    //    string macMid = System.Configuration.ConfigurationManager.AppSettings["Mid"].ToString();
                    //    positionWindowMid(macMid + ":" + GlobalUsage.Login_id, PanelMid);
                    //    string macRight = System.Configuration.ConfigurationManager.AppSettings["Right"].ToString();
                    //    positionWindowRight(macRight + ":" + GlobalUsage.Login_id, PanelRight);
                    //}
                }
                else
                { MessageBox.Show("Please check user id and password"); }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnScanDoc_Click(object sender, EventArgs e)
        {
            Show_scanDocument obj = new Show_scanDocument();
            obj.Owner = this;
            obj.Show();
        }

        private void rbe_AuditRegister_Click(object sender, EventArgs e)
        {
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            TestList obj = new TestList();
            obj.Owner = this;
            obj.Show();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
           
        }

        private void rb_test_audit_Click(object sender, EventArgs e)
        {
            UPHealthTat obj = new UPHealthTat();
            obj.Owner = this;
            obj.Show();
        }

        private void rbe_searchpif_Click(object sender, EventArgs e)
        {
            SearchPatientInDocument obj = new SearchPatientInDocument();
            obj.Owner = this;
            obj.Show();
        }

        private void rb_query_on_sample_Click(object sender, EventArgs e)
        {
            UPHealthQuerry obj = new UPHealthQuerry();
            obj.Owner = this;
            obj.Show();
        }

        private void rb_update_software_Click(object sender, EventArgs e)
        {
            AutoUpdater obj = new AutoUpdater();
            obj.Owner = this;
            obj.Show();
        }

        private void rb_package_doc_Click(object sender, EventArgs e)
        {
            if(GlobalUsage.UnitId=="SLAB")
            {
                BundleScanDocs obj = new BundleScanDocs();
                obj.Owner = this;
                obj.Show();
            }
        }
        private void btnUpdateSoftware_Click(object sender, EventArgs e)
        {

        }

        private void btnNotLinked_Click(object sender, EventArgs e)
        {
            NotLinkedUPHealthTat obj = new NotLinkedUPHealthTat();
            obj.Owner = this;
            obj.Show();
        }

        private void rb_new_Click(object sender, EventArgs e)
        {
        }
        private void OpenControl(UserControl obj, string Title)
        {
            Cursor.Current = Cursors.WaitCursor;
            MasterForm useForm = new MasterForm(obj, Title);
            useForm.Owner = this;
            useForm.Show();
            Cursor.Current = Cursors.Default;
        }

        private void rb_comstatus_Click(object sender, EventArgs e)
        {
          
        }

        private void rb_assetlist_Click(object sender, EventArgs e)
        {
          
        }

        private void rbprinttransferform_Click(object sender, EventArgs e)
        {
           
        }

        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            CorrectMissingDocument obj = new CorrectMissingDocument();
            obj.Owner = this;
            obj.Show();
        }

    }
}
