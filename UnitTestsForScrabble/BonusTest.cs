using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleFinalProject.Controller;

using System;

namespace ScrabbleTests
{
    [TestClass]
    public class BonusTest
    {

        Bonus bonus = new Bonus(3);
        Bonus bonus2 = new Bonus(15);



        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreNotEqual(bonus.BonusMultiplier, null);
            Assert.AreNotEqual(bonus2.BonusMultiplier, null);
            Assert.AreEqual(bonus.BonusMultiplier, 3);
            Assert.AreEqual(bonus2.BonusMultiplier, 15);

        }

        [TestMethod]
        public void GetBonusValueTest()
        {
            Assert.AreEqual(bonus2.getBonusValue(), 15);
            Assert.AreNotEqual(bonus2.getBonusValue(), null);
            Assert.AreNotEqual(bonus.getBonusValue(), null);
            Assert.AreEqual(bonus.getBonusValue(), 3);
            Assert.AreNotEqual(bonus.getBonusValue(), "3");
            Assert.AreNotEqual(bonus2.getBonusValue(), "15");
        }



    }


}
