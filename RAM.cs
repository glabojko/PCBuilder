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


        private RAM(string name, int powerUsage) : base(name, powerUsage)
        {
        }

        public static RAM Instance(string name, int powerUsage)
        {
            
            
                if (instance == null)
                {
                    instance = new RAM(name, powerUsage);
                }
                return instance;
            
        }

        


    }
}
