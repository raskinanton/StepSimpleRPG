using StepSimpleRPG.Players;
using System;

namespace StepSimpleRPG.Items
{
    public class Armor : IItem
    {
        private readonly int _armorupRate;

        public string Name { get; set; }

        public Armor (int armorupRate, string name = "No name")
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));
            Name = name;
            _armorupRate = armorupRate > 0 ? armorupRate : throw new Exception("ArmorupRate value cannot be negative or zero");
        }

        public void Apply(IPlayer player)
        {           
            try
            {
                player.Specs.Damage += _armorupRate;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Can`t add armor. Exeption: {ex.Message}");
            }
        }

        public override string ToString()
        {
            return $"InemName: {Name}, armorupRate: {_armorupRate}";
        }
    }
}
