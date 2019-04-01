using NUnit.Framework;

namespace Tests
{
    public class Account
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DepotSommeNegative()
        {
            Assert.IsTrue("".Equals("La somme introduite est invalide"));
        }
        [Test]
        public void DepotSommeAlphanumerique()
        {
            Assert.IsTrue("".Equals("La somme introduite est invalide"));
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