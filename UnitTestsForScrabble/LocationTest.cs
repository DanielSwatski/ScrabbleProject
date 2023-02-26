using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleFinalProject.Controller;

using System;

namespace ScrabbleTests
{
    [TestClass]
    public class LocationTest
    {
        Location loc = new Location(5, 3);
        Location loc2 = new Location(9, 8, 3);

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreNotEqual(loc, null);
            Assert.AreEqual(loc.Column, 5);
            Assert.AreEqual(loc.Row, 3);
            Assert.AreNotEqual(loc.Column, "5");
            Assert.AreNotEqual(loc.Row, "3");
            Assert.AreNotEqual(loc.Row, null);
            Assert.AreNotEqual(loc.Column, null);
            Assert.AreNotEqual(loc, loc2);
            Assert.AreEqual(loc.bonus, null);

        }

        [TestMethod]
        public void ConstructorTestBonus()
        {
            Assert.AreNotEqual(loc2, null);
            Assert.AreEqual(loc2.Column, 9);
            Assert.AreEqual(loc2.Row, 8);
            Assert.AreNotEqual(loc2.bonus, null);
            Assert.AreEqual(loc2.bonus, 3);
            Assert.AreNotEqual(loc2.Column, "9");
            Assert.AreNotEqual(loc2.Row, "8");
            Assert.AreNotEqual(loc2.Row, null);
            Assert.AreNotEqual(loc2.Column, null);
            Assert.AreNotEqual(loc2, loc);



        }

        [TestMethod]
        public void ToStringTest()
        {
            String actual = loc.ToString();
            String expected = "row: " + loc.row + " column: " + loc.column + " bonus: " + loc.bonus;

            Assert.AreNotEqual(loc.ToString(), null);
            Assert.AreEqual(expected, actual);
            Assert.AreNotEqual(loc.ToString(), "");
            Assert.AreEqual(loc.bonus.ToString(), null);


        }




    }


}
