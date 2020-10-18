﻿using StepSimpleRPG.Players;
using System;

namespace StepSimpleRPG.Items
{
    internal class Armor : IItem
    {
        private readonly int _armorupRate;

        public string Name { get; private set; }

        internal Armor (int armorupRate, string name = "No name")
        {
            Name = name == string.Empty ? "No name" : name;
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

        public override string ToString()
        {
            return $"InemName: {Name}, armorupRate: {_armorupRate}";
        }
    }
}
