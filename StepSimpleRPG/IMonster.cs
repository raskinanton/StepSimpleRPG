﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepSimpleRPG
{
    public interface IMonster
    {
        bool Atack(IPlayer player);
        void Pass (IPlayer player);
    }
}