using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SOAFramework.Client.Controls
{
    public static class ReflectionExtension
    {
        public static T GetValue<T>(this object obj, string propertyName)
        {
            return (T)obj.GetValue(propertyName);
        }

        public static object GetValue(this object obj, string propertyName)
        {
            Type type = obj.GetType();
            var property = type.GetProperty(propertyName);
            if (property == null)
            {
                throw new Exception("类型：" + type.FullName + "中没有属性：" + propertyName);
            }
            object value = null;
            value = property.GetValue(obj, null);
            return value;
        }
    }
}
