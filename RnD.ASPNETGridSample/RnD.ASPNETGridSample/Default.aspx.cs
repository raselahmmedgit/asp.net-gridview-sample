using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RnD.ASPNETGridSample.Helpers;

namespace RnD.ASPNETGridSample
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DynamicReportViewModel dynamicReportViewModel = new DynamicReportViewModel();
            dynamicReportViewModel["Name"] ="Rasel";
            dynamicReportViewModel["Address"] = "Dhaka";
            dynamicReportViewModel["Phone"] = "01911045573";
            dynamicReportViewModel["Email"] = "rasel@gmail.com";

            var model = dynamicReportViewModel;

            DynamicReportViewModel2 dynamicReportViewModel2 = new DynamicReportViewModel2();
            dynamicReportViewModel2.AddProperty<String>("Name", "Rasel");
            dynamicReportViewModel2.AddProperty("System.String", "Address", "Dhaka");

            var model2 = dynamicReportViewModel2;

            
        }
    }
}
