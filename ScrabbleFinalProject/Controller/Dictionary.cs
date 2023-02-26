using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleFinalProject.Controller
{


    // https://stackoverflow.com/questions/38416265/c-sharp-checking-if-a-word-is-in-an-english-dictionary
    public class Dictionary
    {
        // This could probably be coded differently to actually work well but it functions find for now
        //List<String> usableWords;
        public NetSpell.SpellChecker.Spelling dict;

        // May look confusing but this is actually how we check to see if the word is legit
        public Dictionary(String diction)
        {
            
            // Work on adding the french and spanish options later will focus on just english dictionary for now
            NetSpell.SpellChecker.Dictionary.WordDictionary dictRef= new NetSpell.SpellChecker.Dictionary.WordDictionary();
            dictRef.DictionaryFile = diction;
            dictRef.Initialize();

            dict = new NetSpell.SpellChecker.Spelling();

        }


        public Boolean isInDictionary(String word)
        {
            return this.dict.TestWord(word);
        }

    }





}
