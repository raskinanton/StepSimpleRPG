using StepSimpleRPG.Players;

namespace StepSimpleRPG.Items
{
    public interface IItem
    {
        string Name { get; }

        void Apply(IPlayer player);
        string ToString();
    }
}
