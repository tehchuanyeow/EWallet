using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWallet_ClassLibrary
{
    public class AdminAccount : Account
    {
        public void createAccount() { }
        public void deleteAccount() { }
        public void searchAccount() { }
        public void updateAccount() { }

        public AdminAccount(int acctnumber, string acctpassword, string acctusername, User admin) : base(acctnumber, acctpassword, acctusername) {
        }
    }
}
