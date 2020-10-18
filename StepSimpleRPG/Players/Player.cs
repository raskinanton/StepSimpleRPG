using StepSimpleRPG.Items;
using StepSimpleRPG.Misc;
using System.Collections.Generic;

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
            _specs = new Specifications()
            {
                Armor = armor,
                Coin = coin,
                Exp = exp,
                Health = health,
                Name = name
            };
        }
        public Player(Specifications specs)
        {
            _specs = specs;

        }
        public List<IItem> Items { get; set; }
        public Specifications Specs { get => _specs; set { _specs = value; } }
    }
}
