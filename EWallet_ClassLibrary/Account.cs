using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWallet_ClassLibrary
{
    public class Account
    {
        public int acctNumber { get; set; }
        public string acctPassword { get; set; }
        public string acctUserName { get; set; }
        public User userPerson { get; set; }

        public void LoginAccount(string acctusername, string acctpassword) { }
        public void LogoutAccount(string acctusername, string acctpassword) { }

        public Account(int acctnumber, string acctpassword, string acctusername) {
            acctNumber = acctnumber;
            acctPassword = acctpassword;
            acctUserName = acctusername;
            
        }
    }
}
