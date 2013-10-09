using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RnD.ASPNETGridSample.Models;
using RnD.ASPNETGridSample.Helpers;
using System.Reflection;
using System.Data;

namespace RnD.ASPNETGridSample
{
    public partial class BasicGridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AppDbContext _db = new AppDbContext();

            var productList = _db.Products.ToList();

            DynamicReportViewModel obj1 = new DynamicReportViewModel();
            obj1["Name"] = "Rasel";
            obj1["Address"] = "Cantormrnt";
            obj1["Phone"] = "01911045573";
            obj1["Email"] = "rasel@gmail.com";

            DynamicReportViewModel obj2 = new DynamicReportViewModel();
            obj2["Name"] = "Sohel";
            obj2["Address"] = "Uttara";
            obj2["Phone"] = "01911045573";
            obj2["Email"] = "sohel@gmail.com";

            DynamicReportViewModel obj3 = new DynamicReportViewModel();
            obj3["Name"] = "Shafin";
            obj3["Address"] = "Banani";
            obj3["Phone"] = "01911045573";
            obj3["Email"] = "shafin@gmail.com";

            var model = new List<DynamicReportViewModel>() { obj1, obj2, obj3 };

            //Convert To DataTable
            //DictionaryToDataTable.ConvertTo<DynamicReportViewModel>(model, "");

            var columnNameList = new List<string>() { "Name", "Price" };

            var dynamicReportViewModelList = new List<DynamicReportViewModel>();
            foreach (var item in productList)
            {
                var propertyNameList = PropertyInfoHelper.GetPropertyNameList(item);

                DynamicReportViewModel dynamicReportViewModel = new DynamicReportViewModel();

                var isColumnName = columnNameList.Contains("");

                foreach (var columnName in columnNameList)
                {
                    var isSame = PropertyInfoHelper.IsSamePropertyName(item, columnName);


                }

                dynamicReportViewModel["ProductId"] = item.ProductId;
                dynamicReportViewModel["Name"] = item.Name;
                dynamicReportViewModel["Price"] = item.Price;
                dynamicReportViewModel["CategoryId"] = item.CategoryId;

                dynamicReportViewModelList.Add(dynamicReportViewModel);
            }

            

            var aaaa = dynamicReportViewModelList;

            DataTable proList = PropertyInfoHelper.ConvertListObjectToDataTable<Product>(productList);

            //proList.Columns.Remove("Name");

            //var tttt = proList;

            foreach (var colName in columnNameList)
            {

                proList.Columns.Remove(colName);

            }

            this.gvBasicByCode.DataSource = proList;
            //this.gvBasicByCode.DataSource = tttt;
            //this.gvBasicByCode.DataSource = productList;
            //this.gvBasicByCode.DataSource = model;
            this.gvBasicByCode.DataBind();
        }
    }
}