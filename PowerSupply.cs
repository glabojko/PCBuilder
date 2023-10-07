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
        public PowerSupply(string name, int powerUsage) : base(name, powerUsage)
        {
        }

        public static PowerSupply Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PowerSupply("Zasilacz 200W", 200);
                }
                return instance;
            }
        }
    }
}
