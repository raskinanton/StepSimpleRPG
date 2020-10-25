using StepSimpleRPG.Items;
using StepSimpleRPG.Players;
using System;
using System.Collections.Generic;

namespace StepSimpleRPG.Monsters
{
    class MediumMonster: EasyMonster
    {
        public  MediumMonster()
        {
            _specs.Name = "MediumMonster";
            _specs.Health = 10 + rnd.Next(-3, 3);
            _specs.Coin = 2 + rnd.Next(-1, 4);
            _specs.Armor = 2 + rnd.Next(-1, 3);
            _specs.Exp = 6 + rnd.Next(-1, 3);
            _PassCost = 2 + rnd.Next(1, 3);
            _items = new List<IItem>();
            _items.Add(new Treasure(3 + rnd.Next(-1, 5)));
            _items.Add(new Potion(3 + rnd.Next(-1, 5)));
        }

        public override bool TryAtack(IPlayer player)
        {
            if (!base.TryAtack(player))
            {
                player.Specs.Exp += 2;
                player.pushItems(_items); //у игрока реализовать данный метод(для добавления ему вещей в случае его победы);

                return false;
            }
            return true;
        }
        public override string ToString()
        {
            return $"{_specs.Name}, health: {_specs.Health}, coin: {_specs.Coin}, armor: {_specs.Armor}, Exp:{_specs.Exp}";
        }
    }
}
