using StepSimpleRPG.Items;
using StepSimpleRPG.Players;
using System.Collections.Generic;

namespace StepSimpleRPG.Monsters
{
    class MediumMonster: EasyMonster
    {
        public  MediumMonster()
        {
            _specs.Name = "MediumMonster";
            _specs.Health = 10;
            _specs.Coin = 2;
            _specs.Armor = 2;
            _specs.Exp = 6;
            _PassCost = 2;
            _items = new List<IItem>();
            _items.Add(new Treasure(2));
            _items.Add(new Potion(2));
        }
        public override bool Atack(IPlayer player)
        {
            if (!base.Atack(player))
            {
                player.Specs.Exp += 2;
                //player.pushItems(_items); //у игрока реализовать данный метод(для добавления ему вещей в случае его победы);

                return false;
            }
            return true;
        }
        public override string ToString()
        {
            return $"{_specs.Name}, health: {_specs.Health}, coin: {_specs.Coin}, armor: {_specs.Armor}, Exp:{_specs.Exp}";
        }
    }
}
