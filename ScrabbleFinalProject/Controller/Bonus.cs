using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleFinalProject.Controller
{
    // Added this as another class under location so we can create a bonus multiplier concept
    public class Bonus
    {
        int bonusMultiplier;
        public Bonus(int bonusMultiplier)
        {
            this.bonusMultiplier = bonusMultiplier;
        }

        
        public int getBonusValue()
        {
            return this.bonusMultiplier;
        }

        public int BonusMultiplier { get => bonusMultiplier; set => bonusMultiplier = value; }
    }
}
