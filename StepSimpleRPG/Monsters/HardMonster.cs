using StepSimpleRPG.Items;
using StepSimpleRPG.Players;
using System.Collections.Generic;
using System;
namespace StepSimpleRPG.Monsters
{
    class HardMonster : EasyMonster
    {
        public HardMonster()
        {
            _specs.Name = "ордынский 150 килограммовый орк с топором. Этот топор больше меня! Худший из противников что могли мне попасться на пути.";
            _specs.Health = 10 + _rnd.Next(0, 5);
            _specs.Coin = 4 + _rnd.Next(-1, 3);
            _specs.Damage = 10 + _rnd.Next(0, 5);
            _specs.Exp = 2;
            _PassCost = 6 + _rnd.Next(0, 4);
            _items = new List<IItem>();
            _items.Add(new Treasure(4 + _rnd.Next(-1, 5)));
            _items.Add(new Potion(4 + _rnd.Next(-1, 5)));
            _items.Add(new Armor(4 + _rnd.Next(-1, 5)));
        }
        public override bool TryAtack(IPlayer player)
        {
            if (!base.TryAtack(player ?? throw new ArgumentNullException("player is null")))
            {
                player.Specs.Exp += _specs.Exp;
                player.Specs.Damage += 2;
                player.pushItems(_items);
                return false;
            }

            return true;
        }
    }
}