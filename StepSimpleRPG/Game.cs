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
        public void run()
        {
            string action = "";
            do
            {
                Console.WriteLine(_Player.ToString());
                Console.WriteLine("w - Attack\na - Retreat\ns - Heal\n0 - Exit\n");
                Console.WriteLine("Enter action: ");
            }
            while((action = Console.ReadLine()) != "0");
        }
    }
}
