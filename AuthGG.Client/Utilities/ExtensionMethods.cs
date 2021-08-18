using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tcortega.AuthGG.Client.Utilities
{
    static class ExtensionMethods
    {
        //public static string GetQueryString<T>(this T obj)
        //{
        //    var properties = obj.GetType().GetProperties()
        //        .Where(x => x.GetValue(obj, null) != null)
        //        .Select(x => string.Format("{0}={1}", x.Name, HttpUtility.UrlEncode(x.GetValue(obj).ToString())));

        //    return string.Join("&", properties);
        //}

        public static Dictionary<string, string> GetUrlEncodedQuery<T>(this T obj)
        {
            return obj.GetType().GetProperties()
                .ToDictionary(
                    prop => prop.Name.ToLower(),
                    prop => HttpUtility.UrlEncode(prop.GetValue(obj).ToString())
                );
        }
    }
}
