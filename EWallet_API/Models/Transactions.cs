using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EWallet.Models
{
    public class Transactions
    {
        public Transactions(int transnum, int payingacntnum, int payeeacntnum, DateTime date, float amnttrans, string desc)
        {
            TransactionNumber = transnum;
            PayingAccountNumber = payingacntnum;
            PayeeAccountNumber = payeeacntnum;
            Date = date;
            AmountTransferred = amnttrans;
            Description = desc;
        }
        public int TransactionNumber { get; set; }
        public int PayingAccountNumber { get; set; }
        public int PayeeAccountNumber { get; set; }
        public DateTime Date { get; set; }
        public float AmountTransferred { get; set; }
        public string Description { get; set; }
    }
}