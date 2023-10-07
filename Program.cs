using System.Security.Cryptography.X509Certificates;

namespace PCBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy w aplikacji do budowy komputera osobistego!");

            PC firstPC = new PC();


            //firstPC.AddComponent(RAM.Instance("GoodRam", -50));
            //firstPC.AddComponent(RAM.Instance("BadRam", -500));
            //firstPC.AddComponent(PowerSupply.Instance("Zasilacz 400W", 400));

            firstPC.AddRAM(RAM.Instance("GoodRam", -50));
            //firstPC.AddRAM(RAM.Instance("BadRam", -5));
            firstPC.AddCPU(CPU.Instance("IntelCoreI5", -200));
            firstPC.AddPowerSupply(PowerSupply.Instance("Zasilacz 500W", 500));

            Console.WriteLine(firstPC);
            
            Console.WriteLine(firstPC.CheckIfPCWorks());


        }
    }
}