using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepSimpleRPG
{
    class HardMonster: Monster
    {
        List<IItem> _items;

        public HardMonster()
        {
            specs.Name = "HardMonster";
            specs.Health = 30;
            specs.Coin = 3;
            specs.Armor = 10;
            specs.Exp = 20;
        }

        public override string ToString()
        {
            return $"{specs.Name}, health: {specs.Health}, coin: {specs.Coin}, armor: {specs.Armor}, Exp:{ecs.Exp}";
        }

    }
}
