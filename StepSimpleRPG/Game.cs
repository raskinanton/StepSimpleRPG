using StepSimpleRPG.Monsters;
using StepSimpleRPG.Players;
using System;

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
                Console.WriteLine("w - Attack\na - Retreat\ns - Heal\nn-Next\ne - Exit\n");
                Console.WriteLine("Enter action: ");
                action = Console.ReadLine();
                switch (action)
                {
                    case "w":
                        break;
                    case "a":
                        break;
                    case "s":
                        break;
                    case "n":
                        break;
                    case "e":
                        break;
                }
            }
            while(action != "0");
            
        }
    }
}
