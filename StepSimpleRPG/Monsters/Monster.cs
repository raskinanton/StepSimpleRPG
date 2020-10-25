using System;
using StepSimpleRPG.Players;
using StepSimpleRPG.Misc;
using StepSimpleRPG.Items;
using System.Collections.Generic;

namespace StepSimpleRPG.Monsters
{
   abstract class Monster: IMonster
    {

        protected Specifications _specs;
        protected int _PassCost;
        protected List<IItem> _items;


        public Monster()
        {
            _specs = new Specifications();
            _specs.Name = "Monster";
            _specs.Health = 5;
            _specs.Coin = 1;
            _specs.Armor = 0;
            _specs.Exp = 2;
            _PassCost = 5;
            
        }
        public virtual bool Atack(IPlayer player)
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 10);
            player.Specs.Health -= _specs.Exp;
            if (result <= 3)
            {
                _specs.Health = 0;
                player.Specs.Coin += _specs.Coin;
                _specs.Coin = 0;
                return false;
            }
            return true;
          
        }

        public virtual void Pass(IPlayer player)
        {
            if (_specs.Coin >= _PassCost)
            {
                player.Specs.Coin += _PassCost;
                _specs.Coin -= _PassCost;
                
            }
            else
            {
                Atack(player);
            }
        }
    }
}

