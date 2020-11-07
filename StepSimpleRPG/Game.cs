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
        private PhrasesKeeper _phrases;

        public Game(IPlayer player, IMonster monster)
        {
            _player = player;
            _monster = monster;
            _phrases = new PhrasesKeeper();
        }
        public void run()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine(_player.ToString());
                    Console.ResetColor();
                    Console.WriteLine("\nm - Идти дальше\nw - Атаковать\na - Отступить\ns - Перевязать раны\n0 - Выйти из игры");
                    Console.Write("Выберите действие, мой милорд: ");
                    var action = Console.ReadLine();
                    Console.Clear();
                    switch (action)
                    {
                        case "m":
                            Move();
                            break;
                        case "w":
                            if (!IsMonsterNewGenerate())
                                break;
                            Attack();
                            break;
                        case "a":
                            Retreat();
                            break;
                        case "s":
                            Heal();
                            break;
                        case "0":
                            Console.WriteLine("Эх! Хорошее было путешествие!\n<<< Конец саги >>>");
                            return;
                        default:
                            Console.WriteLine(_phrases.GetPhraseIfWrongCommandWasEntered());
                            break;
                    }
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private bool IsMonsterNewGenerate()
        {
            if (_isGenerateNewMonster)
                return true;

            Console.WriteLine(_phrases.GetPhraseIfThereIsNoMonserAround());
            return false;
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

        private void Heal()
        {
            if (_player.tryTreatment())
            {
                Console.WriteLine("На этот раз я смог перевязать свои раны. Но в следующий раз мне стоит быть аккуратнее.");
            }
            else
            {
                Console.WriteLine("Ахххх! Мне нечем зашить эту рану. Куда я дел эту иглу?");
            }
        }

        private void Retreat()
        {
            if (IsMonsterNewGenerate())
            {
                _monster.TryPass(_player);
            }
        }

        private void Attack()
        {
            if (_monster.TryAtack(_player))
            {
                _isGenerateNewMonster = false;
                Console.WriteLine(_phrases.GetPhraseIfAttackWasSucsessfull());
            }
            else
            {
                Console.WriteLine(_phrases.GetPhraseIfAttackWasNotSucsessfull());
            }
        }

        private void Move()
        {
            _monster = CreateMonster(_player);
            _isGenerateNewMonster = true;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_monster.ToString());
            Console.ResetColor();
        }
    }
}