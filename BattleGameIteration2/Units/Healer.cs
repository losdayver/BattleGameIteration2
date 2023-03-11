using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGameIteration2.Units
{
    internal class Healer : Unit, ISpecialAbility
    {
        public Healer()
        {
            unitName = "Целитель";
            attack = 1;
            defense = 1;
            hitPoints = 1;
            specialStrength = 2;
            specialRange = 5;
        }

        public int specialStrength { get; set; }
        public int specialRange { get; set; }
    }
}
