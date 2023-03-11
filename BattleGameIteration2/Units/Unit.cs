using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGameIteration2.Units
{
    abstract internal class Unit
    {
        public string unitName;
        public int attack;
        public int defense;
        public int hitPoints;

        public void TakeDamage(Unit opponent)
        {
            hitPoints -= opponent.attack;
        }

        public void TakeSpecialDamage(ISpecialAbility opponent)
        {
            hitPoints -= opponent.specialStrength;
        }

        public string GetInfo()
        {
            return $"{unitName}, жизнь: {hitPoints}";
        }
    }
}
