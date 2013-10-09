using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Dynamic;
using System.Data;
using System.ComponentModel;

namespace RnD.ASPNETGridSample.Helpers
{
    public class DynamicReportViewModel
    {
        Dictionary<string, object> properties = new Dictionary<string, object>();

        public object this[string name]
        {
            get
            {
                if (properties.ContainsKey(name))
                {
                    return properties[name];
                }
                return null;
            }
            set
            {
                properties[name] = value;
            }
        }
    }

    public class DynamicReportViewModel2 : DynamicObject
    {
        Dictionary<string, object> dictionary
               = new Dictionary<string, object>();
        public int Count
        {
            get
            {
                return dictionary.Count;
            }
        }
        public override bool TryGetMember(
            GetMemberBinder binder, out object result)
        {
            string name = binder.Name;
            return dictionary.TryGetValue(name, out result);
        }
        public override bool TrySetMember(
            SetMemberBinder binder, object value)
        {
            dictionary[binder.Name] = value;
            return true;
        }
        public void AddProperty<TTValue>(string key, TTValue value = default(TTValue))
        {
            dictionary[key] = value;
        }
        public void AddProperty(string typeName, string key, object value = null)
        {
            Type type = Type.GetType(typeName);
            dictionary[key] = Convert.ChangeType(value, type);
        }
    }

    public class DictionaryToDataTable
    {
        public static DataTable ConvertTo<T>(Dictionary<string, T> list, string dataTableName)
        {
            DataTable table = CreateTable<T>(dataTableName);
            Type entityType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (KeyValuePair<string, T> item in list)
            {
                DataRow row = table.NewRow();
                //System.Reflection.PropertyInfo[] pi = obj.GetType().GetProperties( );
                //System.Reflection.PropertyAttributes pj = obj.GetType().GetCustomAttributes(true);
                //table.Rows.Add(obj);
                foreach (PropertyDescriptor prop in properties)
                    if (prop.PropertyType.Name != "Dictionary`2")
                    {
                        if (prop.PropertyType.FullName == "System.String")
                            if (prop.GetValue(item.Value) == null)
                                row[prop.Name] = prop.GetValue(item.Value);
                            else
                                row[prop.Name] = prop.GetValue(item.Value).ToString().Replace("'", "''");
                        else
                            row[prop.Name] = prop.GetValue(item.Value);
                    }
                table.Rows.Add(row);
            }
            return table;
        }

        public static DataTable CreateTable<T>(string dataTableName)
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(dataTableName);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);
            foreach (PropertyDescriptor prop in properties)
            {
                // HERE IS WHERE THE ERROR IS THROWN FOR NULLABLE TYPES
                table.Columns.Add(prop.Name, prop.PropertyType);
            }

            return table;
        }
    }


}