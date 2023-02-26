using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleFinalProject.Controller;

using System;

namespace ScrabbleTests
{
    [TestClass]
    public class TileTest
    {

        Tile t = new Tile('C', 3);

        [TestMethod]
        public void ConstructorTest()
        {
            Location lo = new Location(2, 3);
            Assert.AreEqual(t.Letter, 'C');
            Assert.AreNotEqual(t.Letter, 'Z');
            Assert.AreNotEqual(t.Letter, 'V');
            Assert.AreNotEqual(t.Location, lo);
            Assert.AreEqual(t.Location, null);
            Assert.AreEqual(t.Value, 3);
            Assert.AreNotEqual(t.Value, 13);
        }

        [TestMethod]
        public void ToStringTest()
        {
            String actual = t.ToString();
            String expected = "Letter: " + t.Letter + "value: " + t.Value + "location: " + t.Location;

            Assert.AreEqual(expected, actual);
            Assert.AreNotEqual(expected, 2);
            Assert.AreNotEqual(expected, t.Value);
            Assert.AreNotEqual(expected, null);

        }



    }
}
