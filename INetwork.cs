using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Factory_Pattern_004
{
    internal interface INetwork
    {
        string GetNameNetWork();
        string GetCarrerNumber();
        string CheckAccountMoney();
    }
}
