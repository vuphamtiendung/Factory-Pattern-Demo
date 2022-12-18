using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Factory_Pattern_004
{
    internal class Mobifone : INetwork
    {
        public string GetNameNetWork()
        {
            return "MOBIFONE";
        }
        public string GetCarrerNumber()
        {
            return "090, 093, 0120, 0121, 0122, 0126, 0128, 089";
        }
        public string CheckAccountMoney()
        {
            return "*101#";
        }
    }
}
