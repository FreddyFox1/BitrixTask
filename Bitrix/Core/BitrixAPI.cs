using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Bitrix.Core
{

    public class BitrixAPI
    {
        public static RestClient RC = new RestClient();
        public static string API { get; set; }
        
        public static string SendRequest(string UserID, string SecretKey, string MethodApi, string Params)
        {
            var URL = API + UserID + "/" + SecretKey + "/" + MethodApi + "?" + Params; //+ Params;
            var Request = new RestRequest(URL);
            var Response = RC.Get(Request);
            return System.Text.RegularExpressions.Regex.Unescape(Response.Content);
        }
    }
}
