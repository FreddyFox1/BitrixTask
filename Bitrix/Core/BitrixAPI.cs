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
        RestClient RC = new RestClient();
        string API = "https://b24-djot23.bitrix24.ru/rest/";

        public string SendRequest(string UserID, string SecretKey, string MethodApi, string Params)
        {
            var URL = API + UserID + "/" + SecretKey + "/" + MethodApi + "?" + Params; //+ Params;
            var Request = new RestRequest(URL);
            var Response = RC.Get(Request);
            return System.Text.RegularExpressions.Regex.Unescape(Response.Content);
        }
    }
}
