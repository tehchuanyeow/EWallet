using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EWallet.Models
{
    public class Invoices
    {
        public Invoices(int invnum, int payingacntnum, int payeeacntnum, float amntpaid, float amntpayable, DateTime duedate)
        {
            InvoiceNumber = invnum;
            PayingAccountNumber = payingacntnum;
            PayeeAccountNumber = payeeacntnum;
            AmountPaid = amntpaid;
            AmountPayable = amntpayable;
            DueDate = duedate;
        }
        public int InvoiceNumber { get; set; }
        public int PayingAccountNumber { get; set; }
        public int PayeeAccountNumber { get; set; }
        public float AmountPaid { get; set; }
        public float AmountPayable { get; set; }
        public DateTime DueDate { get; set; }
    }
}