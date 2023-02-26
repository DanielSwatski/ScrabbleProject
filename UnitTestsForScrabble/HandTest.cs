using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleFinalProject.Controller;

using System;

namespace ScrabbleTests
{
    [TestClass]
    public class HandTest
    {

        Hand handOne = new Hand();
        
       

        [TestMethod]
        public void ConstructorTest()
        {
            Tile tile1 = new Tile('A', 1);
            
            handOne.addToHand(tile1);
            Assert.AreNotEqual(handOne, null);
            Assert.AreNotEqual(handOne.TilesinHand, null);
            Assert.AreEqual(handOne.TilesinHand.Count, 1);
            Assert.AreNotEqual(tile1.Value, null);
            Assert.AreNotEqual(tile1.Letter, null);
            Assert.AreEqual(tile1.Value, 1);
            Assert.AreEqual(tile1.Letter, 'A');
        }

        [TestMethod]
        public void AddToHandTest()
        {
            Tile t1 = new Tile('B', 2);
            Tile t2 = new Tile('C', 3);
            Tile t3 = new Tile('D', 2);
            Tile t4 = new Tile('E', 1);
            Tile t5 = new Tile('Z', 8);

            Hand handTwo = new Hand();
            handTwo.addToHand(t1);
            handTwo.addToHand(t2);
            handTwo.addToHand(t3);
            handTwo.addToHand(t4);
            handTwo.addToHand(t5);

            Assert.AreNotEqual(handTwo.TilesinHand.Count, 0);
            Assert.AreNotEqual(handTwo.TilesinHand.Count, null);
            Assert.AreNotEqual(handTwo.TilesinHand[4], null);
            Assert.AreEqual(handTwo.TilesinHand[4], t5);
            Assert.AreEqual(handTwo.TilesinHand.Count, 5);



        }



    }


}
