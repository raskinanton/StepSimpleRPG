using StepSimpleRPG.Players;

namespace StepSimpleRPG.Monsters
{
    public interface IMonster
    {
        bool TryAtack(IPlayer player);
        bool TryPass (IPlayer player);
    }
}
