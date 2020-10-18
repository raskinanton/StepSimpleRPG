using System;
using StepSimpleRPG.Players;

namespace StepSimpleRPG.Items
{
    internal class Armor : IItem
    {
        private readonly int _armorupRate;

        internal Armor (int armorupRate)
        {
            _armorupRate = armorupRate > 0 ? armorupRate : throw new Exception("ArmorupRate value cannot be negative or zero");
        }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
