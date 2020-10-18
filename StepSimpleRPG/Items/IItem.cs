using StepSimpleRPG.Players;

namespace StepSimpleRPG.Items
{
    interface IItem
    {
        void Apply(IPlayer player);
        string ToString();
    }
}
