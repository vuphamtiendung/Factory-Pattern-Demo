﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Factory_Pattern_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserAction user = new UserAction();
            user.Perform();
            ReadLine();
        }
    }
}
