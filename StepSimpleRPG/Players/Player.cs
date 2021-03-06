﻿using StepSimpleRPG.Items;
using StepSimpleRPG.Misc;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;

namespace StepSimpleRPG.Players
{
    public class Player : IPlayer
    {
        private Specifications _specs;
        protected List<IItem> _items { get; set; }

        public Player(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            else
            {
                _specs = new Specifications()
                {
                    Damage = 10,
                    Coin = 2,
                    Exp = 0,
                    Health = 100,
                    Name = name
                };
                _items = new List<IItem>();
            }
        }
        public Player(int damage, int coin, int exp, int health, string name)
        {
            if (damage < 0 || coin < 0 || exp < 0 || health < 0 || string.IsNullOrEmpty(name))
                throw new Exception("Недопустимое значение!");
            else
            {
                _specs = new Specifications()
                {
                    Damage = damage,
                    Coin = coin,
                    Exp = exp,
                    Health = health,
                    Name = name
                };
                _items = new List<IItem> { };
            }
        }
        public Player(Specifications specs)
        {
            _specs = specs;
            _items = new List<IItem> { };

        }

        public bool tryTreatment()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i] is Potion)
                {
                    _items[i].Apply(this);
                    _items.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void pushItems(List<IItem> _items)
        {
            this._items.AddRange(_items);
        }
        public Specifications Specs { get => _specs; set { _specs = value; } }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.Append($"\nИмя: {_specs.Name}");
            str.Append($"\nУрон - {_specs.Damage}, деньги - {_specs.Coin}, опыт - {_specs.Exp}, здороье - {_specs.Health}");
            str.Append("\nПредметы в рюкзаке:");
            foreach (var i in _items)
            {
                str.Append(i.ToString());
                str.Append("\n");
            }
            return str.ToString();
        }
    }
}
