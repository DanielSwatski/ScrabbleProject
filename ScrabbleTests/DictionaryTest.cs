using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleFinalProject.Controller;

using System;

namespace ScrabbleTests
{
    [TestClass]
    public class DictionaryTest
    {
        
        Dictionary dictionary = new Dictionary("English");
        //NetSpell.SpellChecker.Spelling dict;
        String diction;

        /*
        [TestMethod]
        public void ConstructorTest()
        {
            
            NetSpell.SpellChecker.Dictionary.WordDictionary dictRef = new NetSpell.SpellChecker.Dictionary.WordDictionary();
            dictRef.DictionaryFile = diction;
            dictRef.Initialize();
            dict = new NetSpell.SpellChecker.Spelling();
            

            //Assert.AreEqual(dictRef.Initialized, true);
            Assert.AreEqual(diction, "English");


        }
        */

        [TestMethod]
        public void IsInDictionaryTest()
        {
            String word = "aosifje";
            String wordTwo = "hello";

            Assert.AreNotEqual(dictionary.isInDictionary(word), null);
            Assert.AreNotEqual(word, null);
            Assert.AreEqual(dictionary.isInDictionary(word), false);
            Assert.AreEqual(word, "aosifje");
            Assert.AreNotEqual(dictionary.isInDictionary(wordTwo), null);
            Assert.AreNotEqual(wordTwo, null);
            Assert.AreEqual(dictionary.isInDictionary(wordTwo), true);
            Assert.AreEqual(wordTwo, "hello");

        }



    }


}
