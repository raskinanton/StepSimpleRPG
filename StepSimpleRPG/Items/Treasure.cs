using StepSimpleRPG.Players;
using System;

namespace StepSimpleRPG.Items
{
    internal class Treasure : IItem
    {
        private readonly int _coins;

        internal Treasure (int coins)
        {
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
    }
}
