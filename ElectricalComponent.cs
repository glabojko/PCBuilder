using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    public class ElectricalComponent
    {
        string Name { get; set; }
        int PowerUsage { get; set; }

        public ElectricalComponent(string name, int powerUsage)
        {
            Name = name;
            PowerUsage = powerUsage;
        }
    }
}
