using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    public class PowerSupply : ElectricalComponent
    {
        private static PowerSupply? instance;
        private PowerSupply(string name, int powerUsage) : base(name, powerUsage)
        {
        }

        public static PowerSupply Instance(string name, int powerSupply)
        {

                if (instance == null)
                {
                    instance = new PowerSupply(name, powerSupply);
                }
                return instance;
            
        }
    }
}
