using StepSimpleRPG.Players;

namespace StepSimpleRPG.Items
{
    interface IItem
    {
        string Name { get; }

        void Apply(IPlayer player);
        string ToString();
    }
}
