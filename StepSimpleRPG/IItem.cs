using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepSimpleRPG
{
    interface IItem
    {
        void Apply(IPlayer player);
        string ToString();
    }
}
