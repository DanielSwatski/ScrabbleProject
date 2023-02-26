using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleFinalProject.Controller
{
 
    
    public class Word
    {
        List<Tile> wordList;
        int value;


        public Word()
        {
            wordList = new List<Tile>();
            Value = 0;
        }

        public void AddToWordList(Tile addable)
        {
            wordList.Add(addable);
        }

        public void calculateValue()
        {
            foreach(Tile cur in wordList)
            {
               if(cur.Location.Bonus != null) //Location is set to null for some reason
                {
                    value += (cur.Value * cur.Location.Bonus.BonusMultiplier);
                }
               else
                {
                    value += cur.Value;
                }
            }
        }

        public string wordStringForm()
        {

            String returnable = "";

            foreach(Tile cur in wordList)
            {
                returnable += cur.Letter;
            }

            this.calculateValue();

            return returnable;
       
        }


        public void clearData()
        {
            this.wordList.Clear();
            this.value = 0;
        }
        public int Value { get => value; set => this.value = value; }
        internal List<Tile> WordList { get => wordList; set => wordList = value; }
    }



}
