using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGameIteration2.Units
{
    internal class Archer : Unit, ISpecialAbility
    {
        public Archer()
        {
            unitName = "Лучник";
            attack = 1;
            defense = 1;
            hitPoints = 2;
            specialStrength = 2;
            specialRange = 5;
        }

        public int specialStrength { get; set; }
        public int specialRange { get; set; }
    }
}
