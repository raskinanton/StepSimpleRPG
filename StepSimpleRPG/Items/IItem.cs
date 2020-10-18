using StepSimpleRPG.Players;

namespace StepSimpleRPG.Items
{
    public interface IItem
    {
        void Apply(IPlayer player);
        string ToString();
    }
}
