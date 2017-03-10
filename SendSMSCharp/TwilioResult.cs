using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


                string excelFilePath = Path.GetDirectoryName(Application.ExecutablePath) ;
                client.DownloadFile("https://api.twilio.com/2010-04-01/Accounts/"+ssid+"/SMS/Messages.csv", excelFilePath+"Messages.csv");
                Process.Start(@excelFilePath);
            }
          

        }
    }
}
