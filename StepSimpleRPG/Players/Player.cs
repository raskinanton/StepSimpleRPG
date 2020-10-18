using StepSimpleRPG.Items;
using StepSimpleRPG.Misc;
using System.Collections.Generic;

namespace StepSimpleRPG.Players
{
    class Player : IPlayer
    {

        public Player()
        {

        }
        public List<IItem> _items { get; set; }
        public Specifications Specs { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
