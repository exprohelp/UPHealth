using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace UPHealth
{
    public static class GlobalUsage
    {
        public static uph_proxy.UPHealthServicesSoapClient Health_proxy;
        public static Accounts_Proxy.Accounts_WebServiceSoapClient accounts_proxy;
        public static diagProxy.Diagnostic_CS_WebServiceSoap cws;
        public static string LoginId = string.Empty;
        public static string UnitId = string.Empty;
        public static List<RadListDataItem> FillTelrikCombo(DataTable dt)
        {
            List<RadListDataItem> list = new List<RadListDataItem>();
            RadListDataItem li = new Telerik.WinControls.UI.RadListDataItem();
            System.Windows.Forms.ComboBox cb = new System.Windows.Forms.ComboBox();
            li.Value = "Select";
            li.Text = "Select";
            list.Add(li);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new Telerik.WinControls.UI.RadListDataItem(dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
            }
            return list;
        }
    }
}
