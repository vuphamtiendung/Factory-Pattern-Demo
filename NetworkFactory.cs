﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Factory_Pattern_004
{
    internal abstract class NetworkFactory
    {
        public abstract INetwork Create(NetworkType type);
    }
}
