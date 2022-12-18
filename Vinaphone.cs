using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Factory_Pattern_004
{
    internal class Vinaphone : INetwork
    {
        public string GetNameNetWork()
        {
            return "VINAPHONE";
        }
        public string GetCarrerNumber()
        {
            return "091, 094, 083, 084, 085, 081, 082";
        }
        public string CheckAccountMoney()
        {
            return "*101#";
        }
    }
}
