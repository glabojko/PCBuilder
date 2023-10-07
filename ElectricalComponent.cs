using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    public class ElectricalComponent
    {
        string Name { get; }
        public int PowerUsage { get; }

        public ElectricalComponent(string name, int powerUsage)
        {
            Name = name;
            PowerUsage = powerUsage;
        }

        public override string ToString()
        {
            return $"{Name}, {PowerUsage}";
        }
    }
}
