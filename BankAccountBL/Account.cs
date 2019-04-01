using System;
using System.Collections.Generic;

namespace BankAccountBL
{
    public class Account
    {
        public int Id { get; set; }
        public decimal balance { get; set; }
        public decimal decouvert { get; set; }
        public bool IsWithDecouvert { get; set; }

        public string Depot(Transaction transaction)
        {
            decimal amount = 0;
            decimal.TryParse(transaction.Amount, out amount);
            if(amount <= 0)
            {
                return "La somme introduite est invalide";
            }
            if (transaction.TypeT == TypeTransaction.Deposit)
            {
                balance += amount;
                return "Transaction aboutie";
            }
            return "Transaction non aboutie";

        }

        public string Retrait(Transaction transaction)
        {
            decimal amount = 0;
            decimal.TryParse(transaction.Amount, out amount);
            if (amount <= 0)
            {
                return "La somme introduite est invalide";
            }
            if (transaction.TypeT == TypeTransaction.Deposit)
            {
                balance -= amount;
                return "Transaction aboutie";
            }
            return "Transaction non aboutie";
           
        }

        public void Print(List<Transaction> transactions)
        {
            Console.Write("Date d'operation  ||   Somme    ||   Solde   ");
            var solde = 0m;
            decimal amount = 0;
            foreach (var item in transactions)
            {
                decimal.TryParse(item.Amount, out amount);
                solde += amount;
                Console.Write(" {0} || {1} || {2} ", item.DateOperation, item.Amount, solde);
            }
        }

       
    }
}
