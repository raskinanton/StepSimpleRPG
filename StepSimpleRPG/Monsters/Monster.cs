using System;
using StepSimpleRPG.Players;
using StepSimpleRPG.Misc;

namespace StepSimpleRPG.Monsters
{
    class Monster: IMonster
    {

        protected Specifications specs = new Specifications();
        private int _PassCost;

        public Monster()
        {
            specs.Name = "Монстр 1 уровня";
            _PassCost = 2;
            specs.Health = 10;
            specs.Armor = 3;
            specs.Coin = 1;

           
        }
        public bool Atack(IPlayer player)
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 10);
            player.Specs.Health -= specs.Armor;
            if (result <= 3)
            {
         
                specs.Health = 0;
                player.Specs.Coin += specs.Coin;
                return false;
            }
            return true;
          
        }

        public virtual void Pass(IPlayer player)
        {
            player.Specs.Coin += _PassCost;
            if(specs.Coin >= _PassCost)
            specs.Coin -= _PassCost;
            else
            {
                Atack(player);
            }
        }
    }
}

