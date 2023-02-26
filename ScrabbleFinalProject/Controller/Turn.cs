using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleFinalProject.Controller
{


    public class Turn
    {
        private Player whoWent;
        private Word word; // this has been changed from the original document because it makes more sense to just point to the word itself on the bird rather than make a new list
        private int score;



        public Turn(Player whoWent, Word word, int score)
        {
            this.whoWent = whoWent;
            this.Word = word;
            this.Score = score;
        }

        public int Score { get => score; set => score = value; }
        internal Player WhoWent { get => whoWent; set => whoWent = value; }
        internal Word Word { get => word; set => word = value; }
    }


    

    


}
