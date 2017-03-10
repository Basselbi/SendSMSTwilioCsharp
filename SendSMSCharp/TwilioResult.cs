using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SendSMSCharp
{
    class TwilioResult
    {

        public void downloadCSVResult(string ssid,string thoken)
        {


            using (var client = new WebClient())
            {
                client.Credentials = new NetworkCredential(ssid, thoken);
                string url= "https://api.twilio.com/2010-04-01/Accounts/"+ssid+"/SMS/Messages.csv";
                client.DownloadFile("https://api.twilio.com/2010-04-01/Accounts/"+ssid+"/SMS/Messages.csv", "SMSLogs\\Messages.csv");

            }
            Process.Start(@"\\SMSLogs");

        }
    }
}
