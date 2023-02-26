using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleFinalProject.Controller;

using System;

namespace ScrabbleTests
{
    [TestClass]
    public class BoardTest
    {
        

        [TestMethod]
        public void ConstructorTest()
        {
            int height = 15;
            int width = 15;

            Board board = new Board(height, width);
            Location[,] loc = new Location[height,width];
            board.BoardTiles = loc;
            Assert.AreNotEqual(board.boardTiles, null);
            Assert.AreNotEqual(loc, null);
            Assert.AreEqual(board.BoardTiles, loc);

        }


        [TestMethod]
        public void ToStringTest()
        {
            int height = 15;
            int width = 15;
            Board board = new Board(height, width);

            String actual = board.ToString();
            String expected = "WHOLE BOARD: " + String.Join("", board.boardTiles.ToString());
            String expected2 = board.boardTiles.ToString();

            Assert.AreEqual(expected, actual);
            Assert.AreNotEqual(expected, "");
            Assert.AreNotEqual(expected2, "");
            Assert.AreNotEqual(expected, null);
            Assert.AreNotEqual(expected2, null);
            Assert.AreEqual(expected2, actual);

        }




    }


}
