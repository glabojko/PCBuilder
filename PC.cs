using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    public class PC
    {
        private List<ElectricalComponent> _components = new List<ElectricalComponent>();

        private RAM? _ram;

        private CPU? _cpu;

        private PowerSupply? _powerSupply;

        private int PowerUsageSum { get; set; }
        public void AddComponent(ElectricalComponent component)
        {
            _components.Add(component);
        }
        public void AddRAM(RAM ram)
        {
            _ram = ram;
        }

        public void AddCPU(CPU cpu)
        {
            _cpu = cpu;
        }

        public void AddPowerSupply(PowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
        }

        public override string ToString()
        {
            string output = "";
            foreach (ElectricalComponent component in _components)
            {
                output += $@"{component.ToString()}
";              
            }
            output += $@"{_ram} 
{_cpu}
{_powerSupply}";

            return $@"Oto twój PC który składa się z:
{output}";
        }
        
        public void CheckPowerUsage()
        {
            
            //foreach (electricalcomponent component in _components)
            //{
            //    powerusagesum += component.powerusage;
            //}
            PowerUsageSum = _ram.PowerUsage + _cpu.PowerUsage + _powerSupply.PowerUsage;
            // PowerUsageSum = powerUsageSum;
            }
        public string CheckIfPCWorks()
        {
            if (PowerUsageSum < 0)
            {
                return "Dodaj zasilacz bo masz za mało watów!";
            }
            else
            {
                return $"Twój PC zużywa {PowerUsageSum} watów.";
            }
        }
    }
}
