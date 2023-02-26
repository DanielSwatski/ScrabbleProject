using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleFinalProject.Controller
{


    public class Hand
    {
        public const int MAXNUMBER = 7; //max number of tiles in the hand
        List<Tile> tilesinHand;

        public List<Tile>TilesinHand { get => tilesinHand; set => tilesinHand = value; }


        public Hand()
        {
            tilesinHand = new List<Tile>();

        }


        // returns false if the MAXNUMBER IS MET to tell the program to not add anymore stuff
        public bool addToHand(Tile added)
        {
            if (TilesinHand.Count < MAXNUMBER)
            {
                this.tilesinHand.Add(added);
                return true;
            }

            else
                return false;
        }

        // ignore only for debug purpose
        public override string ToString()
        {
            return "TilesinHand " + string.Join("",this.tilesinHand);
        }


    }



}
