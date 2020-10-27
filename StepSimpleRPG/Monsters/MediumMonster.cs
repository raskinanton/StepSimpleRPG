using StepSimpleRPG.Items;
using StepSimpleRPG.Players;
using System;
using System.Collections.Generic;

namespace StepSimpleRPG.Monsters
{
    class MediumMonster : EasyMonster
    {
        public MediumMonster()
        {
            _specs.Name = "MEDIUM MONSTER";
            _specs.Health = 6 + _rnd.Next(0, 5);
            _specs.Coin = 2 + _rnd.Next(-1, 4);
            _specs.Damage = 5 + _rnd.Next(0, 5);
            _specs.Exp = 1;
            _PassCost = 4 + _rnd.Next(0, 3);
            _items = new List<IItem>();
            _items.Add(new Treasure(3 + _rnd.Next(-1, 5)));
            _items.Add(new Potion(3 + _rnd.Next(-1, 5)));
        }

        public override bool TryAtack(IPlayer player)
        {
            if (player == null)
            {
                throw new Exception("player is null");
            }

            if (!base.TryAtack(player))
            {
                player.Specs.Exp += 2;
                player.Specs.Damage += 1;
                player.pushItems(_items);

                return false;
            }
            return true;
        }
    }
}