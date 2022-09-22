using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mission_2;

namespace TestMission2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDebiter()
        {
            Compte cpt = new Compte(12345, "toto", 1000, -500);

            double montant = 2000;

            cpt.Debiter(montant);

            Assert.AreEqual(cpt.Solde, 1000);
        }

        [TestMethod]
        public void TestTransferer()
        {
            Compte cpt = new Compte(12345, "toto", 1000, -500);
            Compte cpt2 = new Compte(12345, "tutu", 1000, -500);

            double montant = 500;

            cpt.Debiter(montant);
            cpt2.Crediter(montant);

            Assert.AreEqual(cpt.Solde, 500);
            Assert.AreEqual(cpt2.Solde, 1500);
        }

        [TestMethod]
        public void TestSuperieur()
        {
            Compte cpt = new Compte(12345, "toto", 1000, -500);
            Compte cpt2 = new Compte(12345, "tutu", 500, -500);

           Assert.AreEqual(cpt.Superieur(cpt2), true);
        }
    }
}
