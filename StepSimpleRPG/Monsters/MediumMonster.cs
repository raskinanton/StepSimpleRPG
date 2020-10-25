using StepSimpleRPG.Items;
using StepSimpleRPG.Players;
using System.Collections.Generic;
using StepSimpleRPG.Misc;
namespace StepSimpleRPG.Monsters
{
    class MediumMonster: Monster
    {
        

        
        public override string ToString()
        {
            return $"{_specs.Name}, health: {_specs.Health}, coin: {_specs.Coin}, armor: {_specs.Armor}, Exp:{_specs.Exp}";
        }
    }
}
