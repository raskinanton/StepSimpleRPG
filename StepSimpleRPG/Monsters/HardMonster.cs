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
            _specs.Name = "HARD MONSTER";
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
            if (player == null)
            {
                throw new Exception("player is null");
            }

            if (!base.TryAtack(player))
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