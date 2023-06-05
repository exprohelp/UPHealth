using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace UPHealth
{
    public partial class PeendingWork : Form
    {
        string _hospid = string.Empty;
        string _input_date = string.Empty;
        string _result = string.Empty;
        public PeendingWork(string hosp_id,string input_date)
        {
            _hospid = hosp_id;
            _input_date = input_date;
            InitializeComponent();
        }

        private void PeendingWork_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds=GlobalUsage.Health_proxy.UPHealth_Queries(out _result, GlobalUsage.UnitId, _hospid, _input_date, "N/A", "GetPendings", GlobalUsage.LoginId);
                rgv_patientcount.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
