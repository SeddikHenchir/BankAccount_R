using BankAccountBL;
using NUnit.Framework;
using System;

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
            Assert.IsTrue("".Equals("La somme introduite est invalide"));
        }
        [Test]
        public void RetraitSommePositive_Inf_Solde()
        {
            Assert.IsTrue("".Equals("La somme introduite est invalide"));
        }
        [Test]
        public void RetraitSommePositive_Sup_Solde_SansDecouvert()
        {
            Assert.IsTrue("".Equals("La somme introduite est invalide"));
        }
        [Test]
        public void RetraitSommePositive_Sup_Solde_Inf_SommeSoldeEtDecouvert()
        {
            Assert.IsTrue("".Equals("La somme introduite est invalide"));
        }
        [Test]
        public void RetraitSommePositive_Sup_SommeSoldeEtDecouvert()
        {
            Assert.IsTrue("".Equals("La somme introduite est invalide"));
        }
        [Test]
        public void RetraitSommeNegative()
        {
            Assert.IsTrue("".Equals("La somme introduite est invalide"));
        }
        [Test]
        public void RetraitSommeAlphanumérique()
        {
            Assert.IsTrue("".Equals("La somme introduite est invalide"));
        }
        [Test]
        public void ImpressionHistorique()
        {
            Assert.IsTrue("".Equals("Compte Inexistant"));
        }
    }
}