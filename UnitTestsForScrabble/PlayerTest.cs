using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleFinalProject.Controller;

using System;

namespace ScrabbleTests
{
    [TestClass]
    public class PlayerTest
    {

        Player p = new Player("Mo");

        public void ConstructorTest()
        {
            Assert.AreEqual(p.PlayerName, "Mo");
            Assert.AreEqual(p.Score, 0);
            Assert.AreEqual(p.Score, "0");
            Assert.AreEqual(p.Score, 15);
            Assert.AreNotEqual(p.Hand, null);
        }

        [TestMethod]
        public void ToStringTest()
        {
            String actual = p.ToString();
            String expected = "playerName:" + p.playerName + "Hand: " + p.Hand + "score: " + p.Score;

            Assert.AreEqual(expected, actual);
            Assert.AreNotEqual(expected, 2);
            Assert.AreNotEqual(expected, p.playerName);
            Assert.AreNotEqual(expected, null);

        }




    }


}
