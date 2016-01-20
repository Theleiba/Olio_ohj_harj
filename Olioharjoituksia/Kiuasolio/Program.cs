using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiuasolio
{
    class Kiuas
    {
        public bool Power()
        {
            return power = false;
        }
        public int Humid()
        {
            return humid;
        }
        public int Therm
        {
            get { return therm; }
            set {
                if (value > 0 && value <= 120)
                {
                    therm = value;
                }
                else therm = 0;
            }
        }
        public int humid;
        public int therm;
        public bool power;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas soona9000 = new Kiuas();
            Console.WriteLine("Paina nappia kiukaan käynnistämiseksi.");
            Console.ReadLine();
            soona9000.power = true;
            soona9000.therm = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kosteuden arvo ");
            soona9000.humid = int.Parse(Console.ReadLine());
        }
    }
}
