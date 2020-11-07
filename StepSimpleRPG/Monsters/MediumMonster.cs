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
            _specs.Name = "тролль равнинный. Быстрый и юркий средний противник. Он умело владет кинжалами и луком. Нужно успевать отражать атаки.";
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
            if (!base.TryAtack(player ?? throw new ArgumentNullException("player is null")))
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