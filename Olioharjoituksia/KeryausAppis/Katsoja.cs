using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeryausAppis
{
    class Katsoja : Henkilo, Fani
    {
        public bool Kausikortti { get; set; }

        public Katsoja()
        {
        }

        public Katsoja(string nimi, double paino, bool kausikortti)
            : base(nimi, paino)
        {
            Kausikortti = kausikortti;

        }

        public override string ToString()
        {
            //Nimi + paino + Kausikortti (base = yliluokan ToString metodi)
            return base.ToString() + Kausikortti;
        }

        public void huutaa()
        {
            Console.WriteLine("NYT BÖNTHÖÖ PERKELE!!!");
        }
    }
}
