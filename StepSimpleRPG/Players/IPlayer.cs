using StepSimpleRPG.Items;
using StepSimpleRPG.Misc;
using System.Collections.Generic;

namespace StepSimpleRPG.Players
{
    public interface IPlayer
    {
        string ToString();
        bool tryTreatment();
        void pushItems(List<IItem> _items);
        Specifications Specs { get; set; }
    }
}
