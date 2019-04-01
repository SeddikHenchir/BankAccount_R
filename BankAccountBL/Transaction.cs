using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountBL
{
    public enum TypeTransaction { Deposit, Withdraw, History };

    public class Transaction
    {
        public string Amount { get; set; }
        public DateTime DateOperation { get; set; }
        public TypeTransaction TypeT { get; set; }

        public Transaction(TypeTransaction myT, string mnt, DateTime today)
        {
            Amount = mnt;
            DateOperation = today;
            TypeT = myT;
        }
    }
}
