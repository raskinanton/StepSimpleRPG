using StepSimpleRPG.Items;
using StepSimpleRPG.Players;
using System.Collections.Generic;

namespace StepSimpleRPG.Monsters
{
    class HardMonster: EasyMonster
    {
       

        public HardMonster()
        {
            _specs = new Misc.Specifications();
            _specs.Name = "HardMonster";
            _specs.Health = 15;
            _specs.Coin = 5;
            _specs.Armor = 5;
            _specs.Exp = 10;
            _PassCost = 4;
            _items = new List<IItem>();
            _items.Add(new Treasure(2));
            _items.Add(new Potion(3));
            _items.Add(new Armor(5));
        }
        public override bool TryAtack(IPlayer player) {
            bool BaseAttack = base.TryAtack(player); 
            if(!BaseAttack)
            {
                player.Specs.Exp += 4;
                //player.pushItems(_items); //у игрока реализовать данный метод(для добавления ему вещей в случае его победы);
                return false;
            }
            return true;
        
        }
        public override bool TryPass(IPlayer player)
        {
           bool result =  base.TryPass(player);         
        if(result)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"{_specs.Name}, health: {_specs.Health}, coin: {_specs.Coin}, armor: {_specs.Armor}, Exp:{_specs.Exp}";
        }

    }
}
