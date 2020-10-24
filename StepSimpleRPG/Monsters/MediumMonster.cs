﻿using StepSimpleRPG.Items;
using StepSimpleRPG.Players;
using System.Collections.Generic;

namespace StepSimpleRPG.Monsters
{
    class MediumMonster: Monster
    {
        List<IItem> _items;

        public  MediumMonster()
        {
            _specs.Name = "MediumMonster";
            _specs.Health = 10;
            _specs.Coin = 2;
            _specs.Armor = 2;
            _specs.Exp = 6;
            _PassCost = 2;
            _items = new List<IItem>();
            _items.Add(new Treasure(2));
            _items.Add(new Potion(2));
        }

        public override string ToString()
        {
            return $"{_specs.Name}, health: {_specs.Health}, coin: {_specs.Coin}, armor: {_specs.Armor}, Exp:{_specs.Exp}";
        }
    }
}
