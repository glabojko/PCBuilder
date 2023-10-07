using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    public class RAM : ElectricalComponent
    {
        private static RAM? instance;
        public RAM(string name, int powerUsage) : base(name, powerUsage)
        {
        }

        public static RAM Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RAM("GoodRAM 32GB", -30);
                }
                return instance;
            }
        }
    }
}
