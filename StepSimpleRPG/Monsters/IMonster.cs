using StepSimpleRPG.Players;

namespace StepSimpleRPG.Monsters
{
    public interface IMonster
    {
        bool Atack(IPlayer player);
        void Pass (IPlayer player);
    }
}
