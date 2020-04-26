using System.Collections.Generic;
using System.Linq;
namespace ObjectHashGenerator.Extension
{
    public static class ObjectToDictionaryExtension
    {
        public static Dictionary<string, object> ObjectToDictionary(this object o)
        {
            System.Reflection.PropertyInfo[] properties = o.GetType().GetProperties();

            Dictionary<string, object> result = properties.ToDictionary(p => p.Name, p => p.GetValue(o));

            return result;
        }
    }
}