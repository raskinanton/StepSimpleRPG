using StepSimpleRPG.Items;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepSimpleRPG.Monsters
{
    class MediumMonster: Monster
    {
        List<IItem> _items;

        public  MediumMonster()
        {
            _specs.Name = "MediumMonster";
            _specs.Health = 20;
            _specs.Coin = 2;
            _specs.Armor = 5;
            _specs.Exp = 10;
        }

        public override string ToString()
        {
            return $"{_specs.Name}, health: {_specs.Health}, coin: {_specs.Coin}, armor: {_specs.Armor}, Exp:{_specs.Exp}";
        }
    }
}
