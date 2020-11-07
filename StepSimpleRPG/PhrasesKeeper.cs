using System;

namespace StepSimpleRPG
{
    public class PhrasesKeeper
    {
        private Random _random;
        private string[] _noMonsterAround = { "Я сделал резкий взмах мечом! \nи понял что нет никого рядом. Я здесь один... Думаю мне стоит двигаться дальше.",
            "Взгляд влево - никого. Взгляд вправо - пусто. Хмм.. Враг быстр как стрела. О нет1 Должно быть он уже позади меня! Я обернулся, но никого не увидел.",
            "Атаковать не получится. Вокруг никого. И это не удивительно. От меня так воняет. Поскорей бы добраться до таверны.",
            "вжуууухх... Хм.. Это был не плохой удар. Молодое деревце повержено. Но мне следует не тратить силы попусту и найти монстра."};
        private string[] _wrongCommand = { "Хммм... Странно. Я сам не понимаю чего хочу. Надо попробовать конкретнее вводить команду", 
            "Моё тело не слушается меня. Чего я хотел когда отдавал такую команду?", 
            "Я должен научиться управлять своим телом лучше. Мне стоит ещё потренироваться и ввести правильную команду."};
        private string[] _sucsessfulAttack = { "Да! Я победил его!" ,
            "Монстр повержен! Я быстр и опасен.",
            "Противник обезглавден. И так будет со всеми монстрами!"};
        private string[] _unsucsessfullAttack = { "Я не смог одолеть этого монстра! Хорошо хоть жив остался.",
            "Фухх. Еле удрал от этого зверюги! Неприяное поражение",
            "Я сильно ранен. В этот раз бой проигран, но я смогу победить монстра в следующий раз!"};

        public PhrasesKeeper()
        {
            _random = new Random();
        }

        public string GetPhraseIfThereIsNoMonserAround()
        {
            return _noMonsterAround[_random.Next(0, _noMonsterAround.Length - 1)];
        }

        public string GetPhraseIfWrongCommandWasEntered()
        {
            return _wrongCommand[_random.Next(0, _wrongCommand.Length - 1)];
        }

        public string GetPhraseIfAttackWasSucsessfull()
        {
            return _sucsessfulAttack[_random.Next(0, _sucsessfulAttack.Length - 1)];
        }

        public string GetPhraseIfAttackWasNotSucsessfull()
        {
            return _unsucsessfullAttack[_random.Next(0, _unsucsessfullAttack.Length - 1)];
        }
    }
}
