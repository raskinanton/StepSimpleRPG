using StepSimpleRPG.Players;
using System;

namespace StepSimpleRPG.Items
{
    internal class Potion : IItem
    {
        private readonly int _healingRate;

        public string Name { get; private set; }

        internal Potion (int healingRate, string name = "No name")
        {
            Name = name == string.Empty ? "No name" : name;
            _healingRate = healingRate > 0 ? healingRate : throw new Exception("HealingRate value cannot be negative or zero");
        }

        public void Apply(IPlayer player)
        {
            try
            {
                player.Specs.Health += _healingRate;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Can`t add healingRate. Exeption: {ex.Message}");
            }
        }

        public override string ToString()
        {
            return $"InemName: {Name}, healingRate: {_healingRate}";
        }
    }
}
