using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleFinalProject.Controller
{
 
    
    public class Player
    {
        String playerName;
        Hand hand;
        int score;

        public string PlayerName { get => playerName; set => playerName = value; }
        public int Score { get => score; set => score = value; }
        public Hand Hand { get => hand; set => hand = value; }

        public Player(String playerName)
        {
            this.playerName = playerName;
            this.score = 0;
            this.hand = new Hand(); //new hand is null for some reason, not sure why at the moment

        }

        public void loadHand()
        {

        }


        public override string ToString()
        {
            return "playerName:" + this.playerName + "Hand: " + this.hand + "score: " + this.score;
        }
    }



}
