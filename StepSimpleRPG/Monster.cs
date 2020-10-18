﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepSimpleRPG
{
    class Monster: IMonster
    {

        protected Specifications specs;
        private int PassCost;

        public Monster()
        {
            specs.Name = "Монстр 1 уровня";
            PassCost = 2;
            specs.Health = 10;
            specs.Armor = 3;
            specs.Coin = 1;

           
        }
        public bool Atack(IPlayer player)
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 10);
            if (result <= 3)
            {
                Console.WriteLine("Монстр проиграл ");
                specs.Health = 0;
                player.Specs.Coin += specs.Coin;
                return false;
            }
            
            player.Specs.Health -= specs.Armor;
            return true;
            
        }

        public virtual void Pass(IPlayer player)
        {
            player.Specs.Coin += PassCost;
            
        }
    }
}
