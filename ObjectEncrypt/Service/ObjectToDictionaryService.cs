using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace ObjectHashGenerator.Services
{
    public static class ObjectToDictionaryService
    {
        public static Dictionary<string, object> ObjectToDictionary(object o)
        {
            Type type = o.GetType();
            PropertyInfo[] properties = type.GetProperties();

            Dictionary<string, object> result = properties.ToDictionary(p => p.Name, p => p.GetValue(o));

            return result;
        }
    }
}