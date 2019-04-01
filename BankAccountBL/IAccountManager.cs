using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountBL
{
    public interface IAccountManager
    {
        string Depot(Account Acc, Transaction transaction);
        string Retrait(Account Acc, Transaction transaction);
        bool Print(List<Transaction> transactions);
    }
}
