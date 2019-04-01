using BankAccountBL;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class AccountTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DepotSommeNegative()
        {
            var amout = "-100";
            var tempAcc = new Account() {
                balance = 1000m,
                decouvert = 0m,
                Id = 1,
                IsWithDecouvert = false
            };
            var tempTrans = new Transaction(TypeTransaction.Deposit, amout, DateTime.Today);
            Assert.IsTrue(tempAcc.Depot(tempTrans).Equals("La somme introduite est invalide"));
        }
        [Test]
        public void DepotSommeAlphanumerique()
        {
            var amout = "-A100";
            var tempAcc = new Account()
            {
                balance = 1000m,
                decouvert = 0m,
                Id = 1,
                IsWithDecouvert = false
            };
            var tempTrans = new Transaction(TypeTransaction.Deposit, amout, DateTime.Today);
            Assert.IsTrue(tempAcc.Depot(tempTrans).Equals("La somme introduite est invalide"));
        }
        [Test]
        public void DepotSommePositive()
        {
            var amout = "100";
            var tempAcc = new Account()
            {
                balance = 1000m,
                decouvert = 0m,
                Id = 1,
                IsWithDecouvert = false
            };
            var tempTrans = new Transaction(TypeTransaction.Deposit, amout, DateTime.Today);
            Assert.IsTrue(tempAcc.Depot(tempTrans).Equals("Transaction aboutie"));
        }
        [Test]
        public void RetraitSommePositive_Inf_Solde()
        {
            var amout = "100";
            var tempAcc = new Account()
            {
                balance = 1000m,
                decouvert = 0m,
                Id = 1,
                IsWithDecouvert = false
            };
            var tempTrans = new Transaction(TypeTransaction.Withdraw, amout, DateTime.Today);
            Assert.IsTrue(tempAcc.Retrait(tempTrans).Equals("Transaction aboutie"));
        }
        [Test]
        public void RetraitSommePositive_Sup_Solde_SansDecouvert()
        {
            var amout = "1500";
            var tempAcc = new Account()
            {
                balance = 1000m,
                decouvert = 0m,
                Id = 1,
                IsWithDecouvert = false
            };
            var tempTrans = new Transaction(TypeTransaction.Withdraw, amout, DateTime.Today);
            Assert.IsTrue(tempAcc.Retrait(tempTrans).Equals("Transaction non aboutie"));
        }
        [Test]
        public void RetraitSommePositive_Sup_Solde_Inf_SommeSoldeEtDecouvert()
        {
            var amout = "900";
            var tempAcc = new Account()
            {
                balance = 600m,
                decouvert = 350m,
                Id = 1,
                IsWithDecouvert = true
            };
            var tempTrans = new Transaction(TypeTransaction.Withdraw, amout, DateTime.Today);
            Assert.IsTrue(tempAcc.Retrait(tempTrans).Equals("Transaction aboutie"));
        }
        [Test]
        public void RetraitSommePositive_Sup_SommeSoldeEtDecouvert()
        {
            var amout = "2000";
            var tempAcc = new Account()
            {
                balance = 1000m,
                decouvert = 550m,
                Id = 1,
                IsWithDecouvert = true
            };
            var tempTrans = new Transaction(TypeTransaction.Withdraw, amout, DateTime.Today);
            Assert.IsTrue(tempAcc.Retrait(tempTrans).Equals("Transaction non aboutie"));
        }
        [Test]
        public void RetraitSommeNegative()
        {
            var amout = "-100";
            var tempAcc = new Account()
            {
                balance = 1000m,
                decouvert = 0m,
                Id = 1,
                IsWithDecouvert = false
            };
            var tempTrans = new Transaction(TypeTransaction.Withdraw, amout, DateTime.Today);
            Assert.IsTrue(tempAcc.Retrait(tempTrans).Equals("La somme introduite est invalide"));
        }
        [Test]
        public void RetraitSommeAlphanumérique()
        {
            var amout = "-A100";
            var tempAcc = new Account()
            {
                balance = 1000m,
                decouvert = 0m,
                Id = 1,
                IsWithDecouvert = false
            };
            var tempTrans = new Transaction(TypeTransaction.Withdraw, amout, DateTime.Today);
            Assert.IsTrue(tempAcc.Retrait(tempTrans).Equals("La somme introduite est invalide"));
        }
        [Test]
        public void ImpressionHistorique()
        {
            var tempAcc = new Account()
            {
                balance = 1000m,
                decouvert = 0m,
                Id = 1,
                IsWithDecouvert = false
            };
            var tempTrans = new List<Transaction>() { };
                for (int i = 1; i<5;i++)
            {
                tempTrans.Add(new Transaction(TypeTransaction.Deposit, 100 + "", DateTime.Today));
            }
                
            Assert.IsTrue(tempAcc.Print(tempTrans));
        }
    }
}