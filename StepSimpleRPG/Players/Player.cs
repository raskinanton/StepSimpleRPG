using StepSimpleRPG.Items;
using StepSimpleRPG.Misc;
using System.Collections.Generic;
using System;
using System.Linq;

namespace StepSimpleRPG.Players
{
    public class Player : IPlayer
    {
        private Specifications _specs;
        public Player(string name)
        {
            _specs = new Specifications()
            {
                Armor = 10,
                Coin = 2,
                Exp = 0,
                Health = 100,
                Name = name
            };
        }
        public Player(int armor, int coin, int exp, int health, string name)
        {
            if (armor < 0 || coin < 0 || exp < 0 || health < 0)
                throw new Exception("Недопустимое значение!");
            else
            {
                _specs = new Specifications()
                {
                    Armor = armor,
                    Coin = coin,
                    Exp = exp,
                    Health = health,
                    Name = name
                };
            }
        }
        public Player(Specifications specs)
        {
            _specs = specs;

        }
        private List<IItem> _items { get; set; }

        
        public void pushItems(List<IItem> _items)
        {
            this._items.Concat(_items);
        }
        public Specifications Specs { get => _specs; set { _specs = value; } }


    }
}
