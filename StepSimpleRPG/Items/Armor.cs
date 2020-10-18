using StepSimpleRPG.Players;
using System;

namespace StepSimpleRPG.Items
{
    internal class Armor : IItem
    {
        private readonly int _armorupRate;

        internal Armor (int armorupRate)
        {
            _armorupRate = armorupRate > 0 ? armorupRate : throw new Exception("ArmorupRate value cannot be negative or zero");
        }

        public void Apply(IPlayer player)
        {           
            try
            {
                player.Specs.Armor += _armorupRate;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Can`t add armor. Exeption: {ex.Message}");
            }
        }
    }
}
