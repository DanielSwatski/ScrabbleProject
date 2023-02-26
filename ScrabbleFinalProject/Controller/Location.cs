using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleFinalProject.Controller
{
 
    
    public class Location
    {
        // should start as -1 -1 for all that are added to the bag
        private int column;
        private int row;
        private Bonus bonus;

        public int Row { get => row; set => row = value; }
        public int Column { get => column; set => column = value; }
        public Bonus Bonus { get => bonus; set => bonus = value; }

        public Location()
        {
            this.column = -1;
            this.row = -1;
            this.bonus = null;
        }

        // Calls if there is no bonus
        public Location(int column, int row)
        {
            this.column = column;
            this.row = row;
            this.bonus = null;
        }

        // Calls if there is a bonus
        public Location(int row, int column, int bonusValue)
        {
            this.row = row;
            this.column = column;
            this.bonus = new Bonus(bonusValue);
        }


        public override String ToString()
        {
            return "row: " + this.row + " column: " + this.column + " bonus: " + this.bonus; // will return the location of the bonus or null
        }
        

    }



}
