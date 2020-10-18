using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepSimpleRPG
{
    internal class Potion : IItem
    {
        private readonly int _healingRate;

        internal Potion (int healingRate)
        {
            _healingRate = healingRate > 0 ? healingRate : throw new Exception("HealingRate count value cannot be negative or zero");
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
    }
}
