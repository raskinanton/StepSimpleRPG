using StepSimpleRPG.Items;
using StepSimpleRPG.Players;
using System.Collections.Generic;
using System;
namespace StepSimpleRPG.Monsters
{
    class HardMonster: EasyMonster
    {
       

        public HardMonster()
        {
            _specs = new Misc.Specifications();
            _specs.Name = "HardMonster";

            _specs.Health = 7 + rnd.Next(-3, 3);
            _specs.Coin = 4 + rnd.Next(-1, 3);
            _specs.Damage = 4 + rnd.Next(1, 2);
            _specs.Exp = 4 + rnd.Next(1, 2);
            _PassCost = 4 + rnd.Next(2, 5);
            _items = new List<IItem>();
            _items.Add(new Treasure(4 + rnd.Next(-1, 5)));
            _items.Add(new Potion(4 + rnd.Next(-1, 5)));
            _items.Add(new Armor(4 + rnd.Next(-1, 5)));
        }
        public override bool TryAtack(IPlayer player) {
            if (player == null)
            {
                throw new Exception("player is null");
            }
            bool BaseAttack = base.TryAtack(player); 
            if(!BaseAttack)
            {
                player.Specs.Exp += 4;
                player.pushItems(_items); 
                return false;
            }
            return true;
        
        }
    }
}
