using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepSimpleRPG
{
    class MediumMonster: Monster
    {
        List<IItem> _items;

        public  MediumMonster()
        {
            specs.Name = "MediumMonster";
            specs.Health = 20;
            specs.Coin = 2;
            specs.Armor = 5;
            specs.Exp = 10;
        }

        public override string ToString()
        {
            return $"{specs.Name}, health: {specs.Health}, coin: {specs.Coin}, armor: {specs.Armor}, Exp:{ecs.Exp}";
        }
    }
}
