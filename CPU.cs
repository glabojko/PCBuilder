using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    public class CPU : ElectricalComponent
    {
        private static CPU? instance;
        public CPU(string name, int powerUsage) : base(name, powerUsage)
        {

        }

        public static CPU Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CPU("IntelCoreI5", -50);
                }
                return instance;
            }
        }
    }
}
