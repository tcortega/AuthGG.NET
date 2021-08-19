using System.Collections.Generic;
using System.Linq;
using System.Web;
using tcortega.AuthGG.Client.DTOs;

namespace tcortega.AuthGG.Client.Utilities
{
    static class ExtensionMethods
    {
        public static Dictionary<string, string> GetUrlEncodedQuery<T>(this T obj)
            where T : BasePayload
        {
            return obj.GetType().GetProperties()
                .ToDictionary(
                    prop => prop.Name.ToLower(),
                    prop => HttpUtility.UrlEncode(prop.GetValue(obj).ToString())
                );
        }
    }
}
