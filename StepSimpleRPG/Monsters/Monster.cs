using System;
using StepSimpleRPG.Players;
using StepSimpleRPG.Misc;

namespace StepSimpleRPG.Monsters
{
    class Monster: IMonster
    {

        protected Specifications _specs = new Specifications();
        protected int _PassCost;

        public Monster()
        {
            _specs.Name = "Монстр 1 уровня";
            _PassCost = 1;
            _specs.Health = 10;
            _specs.Armor = 3;
            _specs.Coin = 2;
            _specs.Exp = 5;           
        }
        public virtual bool Atack(IPlayer player)
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 10);
            player.Specs.Health -= _specs.Armor;
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

