using System;
using StepSimpleRPG.Players;
using StepSimpleRPG.Misc;
using StepSimpleRPG.Items;
using System.Collections.Generic;

namespace StepSimpleRPG.Monsters
{
    class EasyMonster: IMonster
    {

        protected Specifications _specs;
        protected int _PassCost;
        protected List<IItem> _items;


        public EasyMonster()
        {
            _specs = new Specifications();
            _specs.Name = "EasyMonster";
            _specs.Health = 5;
            _specs.Coin = 1;
            _specs.Armor = 0;
            _specs.Exp = 2;
            _PassCost = 5;
            
        }
        public virtual bool TryAtack(IPlayer player)
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 10);
            player.Specs.Health -= _specs.Exp;
            if (result >= 3)
            {              
                player.Specs.Coin += _specs.Coin;
                return false;
            }
            return true;
          
        }

        public virtual bool TryPass(IPlayer player)
        {
            if (player.Specs.Coin >= _PassCost)
            {
                player.Specs.Coin -= _PassCost;
                return true;
            }
            return false;
        }
    }
}

