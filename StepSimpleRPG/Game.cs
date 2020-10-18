using StepSimpleRPG.Monsters;
using StepSimpleRPG.Players;

namespace StepSimpleRPG
{
    public class Game
    { 
        private IPlayer _Player;
        private IMonster _Monster;

        public Game(IPlayer player, IMonster monster)
        {
            _Player = player;
            _Monster = monster;
        }
        public void run() { }


    }
}
