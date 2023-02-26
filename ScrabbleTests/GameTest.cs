using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleFinalProject.Controller;

using System;

namespace ScrabbleTests
{
    [TestClass]
    public class GameTest
    {
        String[] players = { "Mo", "Dan" };


        [TestMethod]
        public void CreateGameTest()
        {
            
            Game game = new Game(players, 15, 15, "English");
            

            game.createGame(players, 15, 15);
            Assert.AreEqual(players.Length, 2);

            


        }

        [TestMethod]
        public void AddPlayerTest()
        {
            Game game = new Game(players, 15, 15, "English");
            game.addPlayer("Mo");
            Assert.AreEqual(game.Player, "Mo");
            Assert.AreEqual(game.Player.Count, 1);
            Assert.AreNotEqual(game.Player.Count, null);
            Assert.AreNotEqual(game.Player.Count, 2);
            Assert.AreNotEqual(game.Player, "Dan");
            
            game.addPlayer("Adam");
            Assert.AreNotEqual(game.Player.Count, null);
            Assert.AreEqual(players.Length, 2);


        }

        [TestMethod]
        public void SelectDictionaryTest()
        {
            Game game = new Game(players, 15, 15, "English");
            Dictionary dict = new Dictionary("English");
            game.selectDictionary("English");

            Assert.AreEqual(game.Dictionary, dict);
            Assert.AreNotEqual(game.Dictionary, "Spanish");
            Assert.AreNotEqual(game.Dictionary, "French");
        }

        [TestMethod]
        public void StartGameTest()
        {
            
        }

    }
}
