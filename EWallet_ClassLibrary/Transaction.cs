using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWallet_ClassLibrary
{
    public class Transaction
    {
        public int Amount { get; set; }
        private int ReceiverID { get; set; }
        private int SenderID { get; set; }
        private DateTime TransactionDateTime { get; set; }
        public Transaction(int amount, int receiverid, int senderid, DateTime transactionDatetime)
        {
            Amount = amount;
            ReceiverID = receiverid;
            SenderID = receiverid;
            TransactionDateTime = transactionDatetime;

        }
    }
}
