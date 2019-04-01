using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountBL
{
    public class AccountManager : IAccountManager
    {
        public string Depot(Account Acc, Transaction transaction)
        {
            decimal amount = 0;
            decimal.TryParse(transaction.Amount, out amount);
            if (amount <= 0)
            {
                return "La somme introduite est invalide";
            }
            if (transaction.TypeT == TypeTransaction.Deposit)
            {
                Acc.balance += amount;
                return "Transaction aboutie";
            }
            return "Transaction non aboutie";
        }

        public bool Print(List<Transaction> transactions)
        {
            Console.Write("Date d'operation  ||   Somme    ||   Solde   ");
            var solde = 0m;
            decimal amount = 0;
            try
            {
                foreach (var item in transactions)
                {
                    decimal.TryParse(item.Amount, out amount);
                    solde += amount;
                    Console.Write(" {0} || {1} || {2} ", item.DateOperation, item.Amount, solde);
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public string Retrait(Account Acc, Transaction transaction)
        {
            decimal amount = 0;
            decimal.TryParse(transaction.Amount, out amount);
            if (amount <= 0)
            {
                return "La somme introduite est invalide";
            }
            if (transaction.TypeT == TypeTransaction.Withdraw)
            {
                if ((amount <= (Acc.balance + Acc.decouvert) && Acc.IsWithDecouvert) || (amount <= Acc.balance))
                {
                    Acc.balance -= amount;
                    return "Transaction aboutie";
                }

            }
            return "Transaction non aboutie";
        }
    }
}
