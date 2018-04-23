using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWallet_ClassLibrary
{
    public class ResourceAccount : Account
    {
        public double acctBalance { get; set; }
        public double amtDeposit { get; set; }
        public double amtWithdraw { get; set; }
        public List<Invoice> invoiceHistory;
        public List<Transaction> transactionHistory { get; set; }

        

        public ResourceAccount(int acctnumber, string acctpassword, string acctusername,double acctbalance, double amtdeposit, double amtwithdraw, List<Invoice> invoicehistory, List<Transaction> transactionhistory) : base(acctnumber,acctpassword, acctusername)
        {
            acctBalance = acctbalance;
            amtDeposit = amtdeposit;
            amtWithdraw = amtwithdraw;
            invoiceHistory = invoicehistory;
            transactionHistory = transactionhistory;
        }

        public void CreateInvoice(DateTime invoiceDateTime, double invoiceId, double invoiceAmt) { }
        public void Deposit(double amtDeposit, int acctNumber) { }
        public void SendInvoice(DateTime invoiceDateTime, int invoiceId, double invoiceAmt) { }
        public void UpdateInvoice(DateTime invoiceDateTime, double invoiceId, double invoiceAmt) { }
    }
}
