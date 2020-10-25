using StepSimpleRPG.Monsters;
using StepSimpleRPG.Players;
using System;

namespace StepSimpleRPG
{
        public class Game
    { 
        private IPlayer _player;
        private IMonster _monster;
        private bool _isGenerateNewMonster = false;

        public Game(IPlayer player, IMonster monster)
        {
            _player = player;
            _monster = monster;
        }
        public void run()
        {
            string action = "";
            do
            {
                Console.WriteLine(_player.ToString());
                Console.WriteLine("m - Move\nw - Attack\na - Retreat\ns - Heal\n0 - Exit\n");
                Console.WriteLine("Enter action: ");
                action = Console.ReadLine();
                switch (action)
                {
                    case "m":
                        _monster = CreateMonster(_player);
                        _isGenerateNewMonster = true;
                        Console.WriteLine(_monster.ToString());
                        break;
                    case "w":
                        if (!IsMonsterNewGenerate())
                            break;
                        if (_monster.TryAtack(_player))
                        {
                            _isGenerateNewMonster = false;
                            Console.WriteLine("win");
                        }
                        else
                        {
                            Console.WriteLine("fail");
                        }
                        break;
                    case "a":
                        if (IsMonsterNewGenerate())
                        {
                            _monster.TryPass(_player);
                        }
                        break;
                    case "s":
                        if (_player.tryTreatment())
                        {
                            Console.WriteLine("heal success");
                        } else
                        {
                            Console.WriteLine("heal failed");
                        }
                        break;
                    case "0":
                        Console.WriteLine("The End!");
                        return;
                }
            }
            while(action != "0");
        }

        private bool IsMonsterNewGenerate()
        {
            if (!_isGenerateNewMonster)
            {
                Console.WriteLine("monstr is not generate");
                _isGenerateNewMonster = false;
                return false;
            }
            return true;
        }

        private IMonster CreateMonster(IPlayer player)
        {
            int exp = player.Specs.Exp;

            if (exp >= 0 && exp <= 5)
                return new EasyMonster();
            if (exp >= 6 && exp <= 9)
                return new MediumMonster();
            if (exp >= 10)
                return new HardMonster();
            return null;
        }
    }
}
