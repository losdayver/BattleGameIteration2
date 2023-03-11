using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGameIteration2.Units
{
    internal class LightInfantry : Unit
    {
        public LightInfantry() 
        {
            unitName = "Легкий пехотинец";
            attack = 1;
            defense = 1;
            hitPoints = 2;
        }
    }
}
