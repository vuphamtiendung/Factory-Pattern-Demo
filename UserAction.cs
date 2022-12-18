using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Factory_Pattern_004
{
    internal class UserAction : ConcreateCreator
    {
        public ConcreateCreator instance;
        public static UserAction useraction;
        public UserAction() { }
        public static UserAction GetUserAction()
        {
            if (useraction == null)
            {
                useraction = new UserAction();
            }
            return useraction;
        }

        public void Perform()
        {
            instance = new ConcreateCreator();

            INetwork viettel = instance.Create(NetworkType.VIETTEL);
            WriteLine(viettel.GetNameNetWork());
            WriteLine(viettel.GetCarrerNumber());
            WriteLine(viettel.CheckAccountMoney());
            WriteLine("-----------------------------");

            INetwork vinaphone = instance.Create(NetworkType.VINAPHONE);
            WriteLine(vinaphone.GetNameNetWork());
            WriteLine(vinaphone.GetCarrerNumber());
            WriteLine(vinaphone.CheckAccountMoney());
            WriteLine("------------------------------");

            INetwork mobiphone = instance.Create(NetworkType.MOBIFONE);
            WriteLine(mobiphone.GetNameNetWork());
            WriteLine(mobiphone.GetCarrerNumber());
            WriteLine(mobiphone.CheckAccountMoney());
            WriteLine("-------------------------------");

            INetwork vietnamobile = instance.Create(NetworkType.VIETNAMOBILE);
            WriteLine(vietnamobile.GetNameNetWork());
            WriteLine(vietnamobile.GetCarrerNumber());
            WriteLine(vietnamobile.CheckAccountMoney());
            WriteLine("-------------------------------");

            INetwork gmobile = instance.Create(NetworkType.GMOBILE);
            WriteLine(gmobile.GetNameNetWork());
            WriteLine(gmobile.GetCarrerNumber());
            WriteLine(gmobile.CheckAccountMoney());
            WriteLine("-------------------------------");
        }
    }
}
