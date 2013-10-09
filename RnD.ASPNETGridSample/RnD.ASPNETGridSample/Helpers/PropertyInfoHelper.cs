using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Data;
using System.ComponentModel;

namespace RnD.ASPNETGridSample.Helpers
{
    public static class PropertyInfoHelper
    {
        public static string[] GetPropertyNameList(dynamic obj)
        {
            List<string> propertyNameList = new List<string>();

            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (PropertyInfo pi in properties)
            {
                propertyNameList.Add(pi.Name);
            }

            return propertyNameList.ToArray();
        }

        public static bool IsSamePropertyName(dynamic obj, string propertyName)
        {
            bool isSamePropertyName = false;

            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (PropertyInfo pi in properties)
            {
                string piName = pi.Name;

                if (propertyName == piName)
                {
                    isSamePropertyName = true;
                    break;
                }
            }

            return isSamePropertyName;
        }

        public static DataTable ConvertListObjectToDataTable<T>(IList<T> dataList)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in dataList)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
    }
}