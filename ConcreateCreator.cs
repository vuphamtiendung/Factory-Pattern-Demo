using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Factory_Pattern_004
{
    internal class ConcreateCreator : NetworkFactory
    {
        /// <summary>
        /// override method
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public override INetwork Create(NetworkType type)
        {
            switch (type)
            {
                case NetworkType.VIETTEL:
                    {
                        return new Viettel();
                    }
                case NetworkType.MOBIFONE:
                    {
                        return new Mobifone();
                    }
                case NetworkType.VINAPHONE:
                    {
                        return new Vinaphone();
                    }
                case NetworkType.VIETNAMOBILE:
                    {
                        return new Vietnamobile();
                    }
                case NetworkType.GMOBILE:
                    {
                        return new Gmobile();
                    }
                default:
                    {
                        throw new ArgumentException("Invalid type", "type");
                    }
            }
        }
    }
}
