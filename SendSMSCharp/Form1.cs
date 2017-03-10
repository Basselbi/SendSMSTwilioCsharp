using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel.Log;
using NUnit.Framework.Constraints;
using RestSharp.Extensions;
using Twilio;
using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account.Message;
using Twilio.Rest.Chat.V1.Service.Channel;
using Twilio.Types;
using MessageResource = Twilio.Rest.Api.V2010.Account.MessageResource;


namespace SendSMSCharp
{
    
    public partial class Form1 : Form
    {
        protected bool isUploaded = false;
        protected List<string> listNumeroTelephon = new List<string>();
        private string path = "";
        private string s = "";
        private string ssid = "";
        private string token = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //    webBrowserBOX.Navigate(new Uri("http://localhost:5000/"));
//            RequestBin req = new RequestBin();
//          req.test();
            msgBOX.Multiline = true;
            comboBox1.Visible = false;

            // Add vertical scroll bars to the TextBox control.
            msgBOX.ScrollBars = ScrollBars.Vertical;
            // Allow the RETURN key to be entered in the TextBox control.
            msgBOX.AcceptsReturn = true;
            // Allow the TAB key to be entered in the TextBox control.
            msgBOX.AcceptsTab = true;
            // Set WordWrap to true to allow text to wrap to the next line.
            msgBOX.WordWrap = true;
            // Set the default text of the control
            msgBOX.Text = "Enter your message here.....";

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
              ssid = twilioSSIDBox.Text;
              token = twilioTokenBox.Text;
             string number = twilioNumberBox.Text;
           
            

            
             if (String.IsNullOrEmpty(ssid))
            {
                MessageBox.Show("You need to enter a Twilio Account SID you can find it at https://www.twilio.com/console");

            }
            else if (String.IsNullOrEmpty(token))
            {
               MessageBox.Show("You need to enter a Twilio Auth Token you can find it at https://www.twilio.com/console");
            }
            else if (String.IsNullOrEmpty(number))
            {
                MessageBox.Show("You need to enter a Twilio registred phone Number you can find it at https://www.twilio.com/console/phone-numbers/");
            }
            else
            {
                try
                {
                    if (isUploaded)
                    {
                        s = comboBox1.Text;
                        ExcelFileReader excelFile = new ExcelFileReader();

                        excelFile.readExcelFile(path, Convert.ToChar(s));
                        listNumeroTelephon = excelFile.NumberListFormatted.ToList();
                        sendSMS(ssid, token, number, listNumeroTelephon, msgBOX.Text);
                        sendMsg.Text = "Sent!";
                        sendMsg.BackColor = Color.LimeGreen;
                    }
                    
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message);
                    // Exception
                }

            }
            

        }

       
        public void sendSMS(string ssid, string token , string fromNumber, List<string>TOnumbersList ,string msgBody )
        {
           TwilioClient.Init("ACd0dfdee5cbece2e6b4226715cc1b7312", "f3ddb423d44f0158ffdf245d0f865c47");

            //var twilio = new TwilioRestClient("ACd0dfdee5cbece2e6b4226715cc1b7312", "f3ddb423d44f0158ffdf245d0f865c47");


            foreach (var toNumber in TOnumbersList)
            {


                var message = MessageResource.Create(
                    to: new PhoneNumber(toNumber),
                    from: new PhoneNumber("(902) 200-4649"),
                    body: msgBody,
                    provideFeedback: true,
                    messagingServiceSid: "MG39f8de2144fa90b91a42cc373365ff81",
             statusCallback: new Uri("https://miniscule-pull.000webhostapp.com/index.php"));
              }
            //Ici , je desire lire les status dont statusCallback de l'API a envoyer

        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> a = new List<string>()
        {
            "q",
            "w",
            "e",
            "r",
            "t",
            "y",
            "u",
            "i",
            "o",
            "p",
            "a",
            "s",
            "d",
            "f",
            "g",
            "h",
            "j",
            "k",
            "l",
            "z",
            "x",
            "c",
            "v",
            "b",
            "n",
            "m",
        };

         
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                button2.Text = Path.GetFileName(path);
                button2.BackColor=Color.LimeGreen;
                comboBox1.Visible = true;
                a = a.ConvertAll(d => d.ToUpper());
                comboBox1.Items.AddRange(a.OrderBy(c => c).ToArray());

            }
            if (!String.IsNullOrEmpty(path))
            {
                comboBox1.Text = "A";
                 s = comboBox1.Text;
                isUploaded = true;

            }
            else
            {
                MessageBox.Show("No file has been selected , please select an .xls or .xlsx file and try again");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sendMsg_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void downloadResult_Click(object sender, EventArgs e)
        {
            ssid = "ACd0dfdee5cbece2e6b4226715cc1b7312";
            token = "f3ddb423d44f0158ffdf245d0f865c47";
            if (!String.IsNullOrEmpty(ssid)&& !String.IsNullOrEmpty(token))
            {
                TwilioResult results = new TwilioResult();
                results.downloadCSVResult(ssid,token);
            }
            else
                MessageBox.Show("SSID cannot be empty , please send sms first !");


        }
    }
}
