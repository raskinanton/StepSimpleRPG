using StepSimpleRPG.Items;
using System.Collections.Generic;

namespace StepSimpleRPG.Players
{
    class Player : IPlayer
    {

        public Player()
        {

        }
        public List<IItem> items { get; set; }
    }
}
