using System;
using StepSimpleRPG.Players;

namespace StepSimpleRPG.Items
{
    public class Treasure : IItem
    {
        private readonly int _coins;

        public string Name { get; private set; }

        public Treasure (int coins, string name = "Золотые монеты")
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));
            Name = name;
            _coins = coins > 0 ? coins : throw new Exception("Coins count value cannot be negative or zero");
        }

        public void Apply(IPlayer player)
        {
            try
            {
                player.Specs.Coin += _coins;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Can`t add coins. Exeption: {ex.Message}");
            }
        }

        public override string ToString()
        {
            return $"{Name}, кол-во монет: {_coins}";
        }
    }
}
