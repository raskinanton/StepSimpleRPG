using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using StepSimpleRPG.Players;

namespace StepSimpleRPG.Items
{
    internal class Treasure : IItem
    {
        private readonly int _coins;

        internal Treasure (string name, int coins)
        {
            Name = name == string.Empty ? "No name" : name;
            _coins = coins > 0 ? coins : throw new Exception("Coins count value cannot be negative or zero");
        }

        public string Name { get; private set; }

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
