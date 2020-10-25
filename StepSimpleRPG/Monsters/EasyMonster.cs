using System;
using StepSimpleRPG.Players;
using StepSimpleRPG.Misc;
using StepSimpleRPG.Items;
using System.Collections.Generic;

namespace StepSimpleRPG.Monsters
{
    class EasyMonster: IMonster
    {
        protected  Random rnd = new Random();
        protected Specifications _specs;
        protected int _PassCost;
        protected List<IItem> _items;


        public EasyMonster()
        {
            Random rnd = new Random();
            _specs = new Specifications();
            _specs.Name = "EasyMonster";
            _specs.Health = 5 + rnd.Next(-3,3);
            _specs.Coin = 2 + rnd.Next(-1, 3);
            _specs.Damage = 2 + rnd.Next(1, 2);
            _specs.Exp = 1 + rnd.Next(1, 2);
            _PassCost = 2 + rnd.Next(2, 5);
            
        }
        public virtual bool TryAtack(IPlayer player)
        {
            if (player == null)
            {
                throw new Exception("player is null");
            }
            Random rnd = new Random();
            int result = rnd.Next(1, 10);
            player.Specs.Health -= _specs.Damage;
            if (result >= 3)
            {
                player.Specs.Exp += _specs.Exp;          
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

        public override string ToString()
        {
            return $"{_specs.Name}, health: {_specs.Health}, coin: {_specs.Coin}, armor: {_specs.Damage}, Exp:{_specs.Exp}";
        }
    }
}

