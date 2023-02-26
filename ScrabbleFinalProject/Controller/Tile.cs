using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleFinalProject.Controller
{
 
    
    public class Tile
    {
        private char letter;
        private Location location;
        private int value;

        public char Letter { get => letter; set => letter = value; }
        public int Value { get => value; set => this.value = value; }
        public Location Location { get => location; set => location = value; }



        // Creates a Tile inside the bag with a location of null and in the player hand making it null
        // when the tile is placed on the board we can have it point to that section on the board
        public Tile(char letter, int value)
        {
            this.letter = letter;
            this.value = value;
            this.Location = new Location(); 

        }

        public Tile()
        {
            this.letter = '*';
            this.value = 0;
            this.location = null;
        }

        public override string ToString()
        {
            return "Letter: " + letter + "vaue: " + value + "location: " + location;
        }



    }



}
