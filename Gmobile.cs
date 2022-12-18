using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Factory_Pattern_004
{
    internal class Gmobile : INetwork
    {
        public string GetNameNetWork()
        {
            return "GMOBILE";
        }
        public string GetCarrerNumber()
        {
            return "099, 059";
        }
        public string CheckAccountMoney()
        {
            return "*101#";
        }
    }
}
