using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EWallet.Models
{
    public class Account
    {
        public Account(int acntnum, string username, string acntname, float acntbal)
        {
            AccountNumber = acntnum;
            UserName = username;
            AccountName = acntname;
            AccountBalance = acntbal;
        }
        public int AccountNumber { get; set; }
        public string UserName { get; set; }
        public string AccountName { get; set; }
        public float AccountBalance { get; set; }
    }
}
