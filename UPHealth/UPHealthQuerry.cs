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
    public partial class UPHealthQuerry : Telerik.WinControls.UI.RadForm
    {
        string[] remarks = {"Select","Sample unusable","Sample not given" };
        int delaycount = 0;
        string _result = string.Empty;
        string _patient_code = string.Empty;
        public UPHealthQuerry()
        {
            InitializeComponent();
        }
        private void PopulateRemarks()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("remark", typeof(string));
                foreach (string s in remarks)
                {
                    ddlRemark.Items.Add(s);
                }
                ddlRemark.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnOpenPat_Click(object sender, EventArgs e)
        {
            FillDetail("QueryListByDate");
        }
        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                DataSet ds =GlobalUsage.Health_proxy.UPHealth_Queries(out _result, GlobalUsage.UnitId, dtFrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"),"0", "Split_TATRegister", GlobalUsage.LoginId);
                dgTAT.DataSource = ds.Tables[0];
                var filter = ds.Tables[0].AsEnumerable().Select(x => new
                {
                    reg_no = x.Field<string>("reg_no"),
                    pt_name = x.Field<string>("pt_name"),
                    UpHealthName = x.Field<string>("UpHealthName"),
                    uph_testcode = x.Field<string>("uph_testcode"),
                    RSLT = x.Field<string>("RSLT")
                }).Distinct();
                dgFilterList.DataSource = filter.ToList();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void UPHealthTat_Load(object sender, EventArgs e)
        {
            GlobalUsage.accounts_proxy = new Accounts_Proxy.Accounts_WebServiceSoapClient();
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
            PopulateRemarks();
            if (GlobalUsage.UnitId == "SLAB")
            {
                panelSampleStatus.Enabled = false;
                TNPPanel.Enabled = true;
            }
            else
            {
                panelSampleStatus.Enabled = true;
                TNPPanel.Enabled = false;
            }
  
        }
        string _reg_no = string.Empty;
        string _uphealthcode = string.Empty;
        private void dgFilterList_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
             gb_TNP.Text = "[" + e.Row.Cells["patient_code"].Value.ToString() + "] " + e.Row.Cells["test_name"].Value.ToString();
            _patient_code = e.Row.Cells["patient_code"].Value.ToString();
            _uphealthcode = e.Row.Cells["uph_testcode"].Value.ToString();
        }
        private void radButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Sure to TNP Of " + gb_TNP.Text + "", "Confirmation", MessageBoxButtons.YesNo).ToString() == "Yes")
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string _result = string.Empty;
                    if (txtTNP.Text.Trim().Length > 5 && _patient_code.Length > 10)
                    {
                        _result =GlobalUsage.Health_proxy.QueryOrTNPTest(GlobalUsage.UnitId, _patient_code, _uphealthcode, GlobalUsage.LoginId, "", "", txtTNP.Text, "DONE_TNP");
                        MessageBox.Show(_result);
                    }
                    else
                    { MessageBox.Show("Please write valid remark or select test "); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void dgFilterList_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["q_flag"].Value.ToString()=="Y")
                e.RowElement.ForeColor = Color.Red;
            else
                e.RowElement.ForeColor = Color.Black;
        }
        private void ddlRemark_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            txtTNP.Text = ddlRemark.SelectedItem.ToString();
        }

        private void MasterTemplate_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["delay"].Value.ToString()=="Y")
            {
                e.RowElement.ForeColor = Color.Red;
            }
            else
            { e.RowElement.ForeColor = Color.Black; }
        }
        private void btnMarkSampleStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Sure to Mark Sample Status " + gb_TNP.Text + "", "Confirmation", MessageBoxButtons.YesNo).ToString() == "Yes")
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string _result = string.Empty;
                    if (ddlRemark.Text!="Select")
                    {
                        _result = GlobalUsage.Health_proxy.QueryOrTNPTest(GlobalUsage.UnitId, _patient_code, _uphealthcode, GlobalUsage.LoginId, "", "", ddlRemark.Text, "QueryOnSample");
                        if(_result.Contains("Success"))
                        {
                          MessageBox.Show("Successfuly done");
                        }
                        else
                        { MessageBox.Show(_result); }
                    }
                    else
                    { MessageBox.Show("Please write valid remark or select test "); }
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void dgTAT_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            txtPatientCode.Text = dgTAT.CurrentRow.Cells["patient_code"].Value.ToString();
            FillDetailForTnp(txtPatientCode.Text);
        }
        private void radButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to mark attended  " + gb_TNP.Text + "", "Confirmation", MessageBoxButtons.YesNo).ToString() == "Yes")
                {
                    if (gb_TNP.Text.Length > 5)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        string _result = string.Empty;
                        _result = GlobalUsage.Health_proxy.QueryOrTNPTest(GlobalUsage.UnitId, _patient_code, _uphealthcode, GlobalUsage.LoginId, "", "", ddlRemark.Text, "QueryAttended");
                        MessageBox.Show(_result);
                    }
                    else
                    { MessageBox.Show("select test "); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void radButton4_Click(object sender, EventArgs e)
        {
            try
            {
                   if (gb_TNP.Text.Length > 5)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        string _result = string.Empty;
                        _result = GlobalUsage.Health_proxy.QueryOrTNPTest(GlobalUsage.UnitId, _patient_code, _uphealthcode, GlobalUsage.LoginId, "", "", txtTNP.Text, "PutRemark");
                        MessageBox.Show(_result);
                    }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void rb_QInProcess_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_QInProcess.Checked)
            {
                PanelQAttended.Enabled = false;
                FillDetail("QueryList_UnAttended");
            }
            else
                PanelQAttended.Enabled = true;
        }

        private void rb_qattended_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void FillDetail(string logic)
        {
            try
            {
                delaycount = 0;
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                //string qry = "execute [dbo].[pUPHealth_Queries] 'U001','2017/05/04','2017/05/04','','QueryList_UnAttended',''";
                 //  DataSet ds =GlobalUsage.lws.GetQueryResult(qry, "UPHealth");
                DataSet ds = GlobalUsage.Health_proxy.UPHealth_Queries(out _result, GlobalUsage.UnitId, dtFrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"), GlobalUsage.UnitId, logic, GlobalUsage.LoginId);
                dgTAT.DataSource = ds.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void FillDetailForTnp(string patient_code)
        {
            try
            {
                delaycount = 0;
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                string qry = "execute [dbo].[pUPHealth_Queries] '"+GlobalUsage.UnitId+"','" + patient_code + "','2017/05/04','','RecordForTNP',''";
                DataSet ds =GlobalUsage.accounts_proxy.GetQueryResult(qry, "UPHealth");
                // DataSet ds = uphproxy.UPHealth_Queries(out _result,GlobalUsage.UnitId, dtFrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"), GlobalUsage.UnitId,logic , GlobalUsage.LoginId);
                dgFilterList.DataSource = ds.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btngetPtDetail_Click(object sender, EventArgs e)
        {
            FillDetailForTnp(txtPatientCode.Text);
        }
    }
}
