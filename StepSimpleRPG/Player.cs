using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepSimpleRPG
{
    class Player : IPlayer
    {

        public Player()
        {

        }
        public List<IItem> items { get; set; }
    }
}
