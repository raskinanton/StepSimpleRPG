using StepSimpleRPG.Items;
using StepSimpleRPG.Players;
using System.Collections.Generic;

namespace StepSimpleRPG.Monsters
{
    class EasyMonster : Monster
    {
        List<IItem> _items;
        public EasyMonster()
        {
            _specs.Name = "Easy Monster";
            _specs.Health = 5;
            _specs.Coin = 1;
            _specs.Armor = 0;
            _specs.Exp = 3;
            _PassCost = 1;
            _items = new List<IItem>();
            _items.Add(new Treasure(1));
        }

        public override string ToString()
        {
            return $"{_specs.Name}, health: {_specs.Health}, coin: {_specs.Coin}, armor: {_specs.Armor}, Exp:{_specs.Exp}";
        }

    }
}
