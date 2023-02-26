using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleFinalProject.Controller;

using System;

namespace ScrabbleTests
{
    [TestClass]
    public class BagTest
    {

        Bag bag = new Bag();

        [TestMethod]
        public void ConstructorTest()
        {
            
            Assert.AreNotEqual(bag, null);
            Assert.AreNotEqual(bag.bag, null);
            Assert.AreEqual(bag.bag.Count, 100);

        }

        [TestMethod]
        public void RandomTileTest()
        {
            Random randNum = new Random();

            int returnIndex = randNum.Next(0, bag.bag.Count);
            Tile returnable = bag.bag[returnIndex];
            bag.bag.RemoveAt(returnIndex);

            Assert.AreNotEqual(randNum, null);
            Assert.AreNotEqual(returnIndex, null);
            Assert.AreNotEqual(returnable, null);
            Assert.AreEqual(returnable, bag.bag[returnIndex]);
            Assert.AreEqual(returnIndex, randNum.Next(0, bag.bag.Count));

        }

        [TestMethod]
        public void ToStringTest()
        {
            bag.ToString();
            String returnable = "";
            for (int i = 0; i < bag.bag.Count; i++)
            {
                returnable = returnable + bag.bag[i].Letter;
                Assert.AreNotEqual(bag.ToString(), null);
                Assert.AreEqual(bag.ToString(), returnable);
            }
            Assert.AreNotEqual(bag.ToString(), null);
            Assert.AreEqual(bag.ToString(), returnable);


        }




    }


}
