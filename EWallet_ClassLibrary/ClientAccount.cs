﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWallet_ClassLibrary
{
    public class ClientAccount : ResourceAccount
    {
        public ClientAccount(int acctnumber,string acctpassword, string acctusername, double acctbalance, double amtdeposit, double amtwithdraw, List<Invoice> invoicehistory, List<Transaction> transactionhistory) : base(acctnumber, acctpassword, acctusername, acctbalance, amtdeposit, amtwithdraw,invoicehistory, transactionhistory)
        {

        }
        public void Withdraw(int acctNumber, double amountWithdraw) { }
    }
}
