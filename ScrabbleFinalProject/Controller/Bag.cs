using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleFinalProject.Controller
{
 
    
    public class Bag
    {
        // does need any getters or setters for this
        public List<Tile> bag;
       // private int tilesInBag;

        //public int TilesInBag { get => tilesInBag; set => tilesInBag = value; }
        


        // shows the numbers and the scores here
        // https://www.thesprucecrafts.com/how-many-letter-tiles-are-in-scrabble-410933
        // https://www.eoiaviles.org/repositorio/mjose/STORIES/death_scrabble/scrabble_rules.html
        public Bag()
        {
            this.bag = new List<Tile>();
            // adds all of the letters here

            // Use the same for loop but break it down by letter
            for(int i = 0; i < 12; i++)
            {
                bag.Add(new Tile('E', 1)); 

                if(i < 9)
                {
                    bag.Add(new Tile('A', 1));
                    bag.Add(new Tile('I', 1));
                }

                if (i < 8)
                    bag.Add(new Tile('O', 1));

                if (i < 6)
                {
                    bag.Add(new Tile('N', 1));
                    bag.Add(new Tile('R', 1));
                    bag.Add(new Tile('T', 1));
                }

                if(i < 4)
                {
                    bag.Add(new Tile('L', 1));
                    bag.Add(new Tile('S', 1));
                    bag.Add(new Tile('U', 1));
                    bag.Add(new Tile('D', 2));
                    bag.Add(new Tile('G', 2));
                }

                //bcfhmpvwy
                if(i < 2)
                {
                    bag.Add(new Tile('B', 3));
                    bag.Add(new Tile('C', 3));
                    bag.Add(new Tile('M', 3));
                    bag.Add(new Tile('P', 3));

                    bag.Add(new Tile('F', 4));
                    bag.Add(new Tile('H', 4));
                    bag.Add(new Tile('V', 4));
                    bag.Add(new Tile('W', 4));
                    bag.Add(new Tile('Y', 4));
                    //bag.Add(new Tile('x', 0)); // this is the bonus tile
                }

                if(i < 1)
                {
                    bag.Add(new Tile('K', 5));

                    bag.Add(new Tile('J', 8));

                    bag.Add(new Tile('X', 10));
                    bag.Add(new Tile('Z', 10));
                }

                // deal with the tile you can make later on that allows you to enter your own tile value
            }
        }


        public Tile randomTile()
        {
            Random randNum = new Random();
            //randNum.Next(0, this.bag.Count);

            int returnIndex = randNum.Next(0, this.bag.Count);
            Tile returnable = bag[returnIndex];
            this.bag.RemoveAt(returnIndex);

            return returnable;
        }

        // returns all tiles in the bag
        public override string ToString()
        {
            String returnable = "";
            for(int i = 0; i < this.bag.Count; i++)
            {
                returnable = returnable + this.bag[i].Letter;
            }

            return returnable;
        }

    }



}
