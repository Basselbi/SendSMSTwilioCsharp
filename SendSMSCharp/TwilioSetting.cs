using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMSCharp
{
     
    class TwilioSetting
    {

        protected string accountSSID ;

        protected string accountToken;

        protected string phoneNumber;

        public TwilioSetting(string accountSSID, string accountToken, string phoneNumber)
        {
            this.accountSSID = accountSSID;
            this.accountToken = accountToken;
            this.phoneNumber = phoneNumber;
        }

        public string AccountSsid
        {
            get { return accountSSID; }
            set { accountSSID = value; }
        }

        public string AccountToken
        {
            get { return accountToken; }
            set { accountToken = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}
