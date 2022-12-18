using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Factory_Pattern_004
{
    internal class Vietnamobile : INetwork
    {
        public string GetNameNetWork()
        {
            return "VIETNAMOBILE";
        }
        public string GetCarrerNumber()
        {
            return "092, 056, 058";
        }
        public string CheckAccountMoney()
        {
            return "*101#";
        }
    }
}
