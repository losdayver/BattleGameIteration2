using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGameIteration2.Units
{
    internal class Knight : Unit
    {
        public Knight()
        {
            unitName = "Рыцарь";
            attack = 3;
            defense = 3;
            hitPoints = 10;
        }
    }
}
