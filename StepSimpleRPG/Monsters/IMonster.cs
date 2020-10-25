using StepSimpleRPG.Players;

namespace StepSimpleRPG.Monsters
{
    public interface IMonster
    {
        bool Atack(IPlayer player);
        bool Pass (IPlayer player);
    }
}
