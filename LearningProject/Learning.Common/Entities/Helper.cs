using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Common.Entities
{
    public static class Helper
    {
        public static string GetObjectString(this object obj)
        {
            var strlist = new List<string>();
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
            {
                var name = descriptor.Name;
                object value = descriptor.GetValue(obj);
                strlist.Add($"{name} ={value}");
            }
            return string.Join(", ", strlist);
        }
    }
}
