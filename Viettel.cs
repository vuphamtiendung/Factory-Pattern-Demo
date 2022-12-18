using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Factory_Pattern_004
{
    internal class Viettel : INetwork
    {
        public string GetNameNetWork()
        {
            return "VIETTEL";
        }
        public string GetCarrerNumber()
        {
            return "086, 096, 097, 098, 032, 033, 034, 035, 036, 037, 038, 039";
        }
        public string CheckAccountMoney()
        {
            return "*101#";
        }
    }
}
