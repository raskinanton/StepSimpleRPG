using StepSimpleRPG.Monsters;
using StepSimpleRPG.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StepSimpleRPG.Game;




namespace StepSimpleRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Tim");
            IMonster monster = new HardMonster();
            Game game = new Game(player, monster);
            game.run();


        }
    }
}
