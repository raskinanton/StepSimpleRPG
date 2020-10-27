using System;
using StepSimpleRPG.Players;
using StepSimpleRPG.Misc;
using StepSimpleRPG.Items;
using System.Collections.Generic;

namespace StepSimpleRPG.Monsters
{
    class EasyMonster : IMonster
    {
        protected Random _rnd;
        protected Specifications _specs;
        protected int _PassCost;
        protected List<IItem> _items;
        public EasyMonster()
        {
            _rnd = new Random();
            _specs = new Specifications();
            _specs.Name = "SMALL MONSTER";
            _specs.Health = 3 + _rnd.Next(0, 3);
            _specs.Coin = 2 + _rnd.Next(-1, 3);
            _specs.Damage = 1 + _rnd.Next(0, 4);
            _specs.Exp = 1;
            _PassCost = 2 + _rnd.Next(0, 3);
        }
        public virtual bool TryAtack(IPlayer player)
        {
            if (player == null)
            {
                throw new Exception("player is null");
            }

            player.Specs.Health -= _specs.Damage;

            if (_rnd.Next(1, 10) >= 3)
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
            return $"I'm {_specs.Name} challenge you to battle\n(ammo:{_specs.Damage}, ${_specs.Coin}, exp:{_specs.Exp}, health:{_specs.Health})";
        }
    }
}