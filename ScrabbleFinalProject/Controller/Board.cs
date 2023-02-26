using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleFinalProject.Controller
{
 
    
    public class Board
    {
        // When creating this board pick some random spots that will be marked as having double letter and tripled letter score. That is all we need. We dont need to add anything for double word or triple word unless we want to later on.
        public Location[,] boardTiles;

        // alter these if we want to later on
        private const int THREEBONUSCOUNT = 3; 
        private const int TWOBONUSCOUNT = 4;

        private const int TWO = 2;
        private const int THREE = 3;
        

        public Location[,] BoardTiles { get => boardTiles; set => boardTiles = value; }

        // Creates the board
        // Mo, ask me how this works because the code looks confusing and I will walk you through it if you cannot figure it out
        public Board(int height, int width)
        {
            this.BoardTiles = new Location[height, width];

            // will also randomly assign a bonus value to a tile
            // We can change the bonus values but will do 3 3s and 4 2s for now
            // will now fill the board with tiles

            // will have them randomly pick the bonus for it 
            // need to come up with good algorithmn to get random distrbution right will need to think about it for a little bit
            // will need to find a fair algorithmn to do this

            //height*i+j will get the current counter for it
            //https://stackoverflow.com/questions/58862845/generate-and-store-7-random-numbers-in-a-array

            Random rand = new Random();
            int[] randomIndex = new int[height + width];
            int addableVal;
            for(int i = 0; i < randomIndex.Length; i++)
            {
                do
                {
                    addableVal = rand.Next(0, this.boardTiles.Length);

                } while (randomIndex.Contains(addableVal));
                randomIndex[i] = addableVal;
            }

            int bonusCounter = 0;
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    // checks to see if this equation is in addableVal and it will assign it a bonus based on the counter of the bonus
                    if (randomIndex.Contains(height * i + j))
                    {
                        if(bonusCounter%2 == 0)
                            this.boardTiles[i, j] = new Location(i, j, TWO);
                        else
                            this.boardTiles[i, j] = new Location(i, j, THREE);

                        bonusCounter++;
                    }
                    else
                    {
                        this.boardTiles[i,j] = new Location(i, j);
                    }
                }
            }

    }

        // used for tostrings
        public override string ToString()
        {
            return "WHOLE BOARD: " + String.Join("", this.boardTiles.ToString());
        }

    }



}
