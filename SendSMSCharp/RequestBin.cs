using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Xml.Linq;
using Twilio.Http;
using HttpClient = System.Net.Http.HttpClient;

namespace SendSMSCharp
{
    class RequestBin
    {
        public RequestBin()
        {
            
        }

        public void test()
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://requestb.in/1jnk4451?inspect");
            request.Method = "POST";                                                 // var task = GetResponseText("http://requestb.in/1jnk4451?inspect");
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            
//            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
//
//           string awp=   sr.ReadToEnd();
            foreach ( var key in response.ContentType)
            {
               Console.WriteLine(key.ToString());
            }
            
        }
        public static string ContentToString(  HttpContent httpContent)
        {
            var readAsStringAsync = httpContent.ReadAsStringAsync();
            return readAsStringAsync.Result;
        }


        public static async Task<string> GetResponseText(string address)
        {
            using (var httpClient = new HttpClient())
                return await httpClient.GetStringAsync(address);
        }
    }
}
