using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio2
{
    class Car
    {
        public Car(string model, int cc)
        {
            this.model = model;
            this.cc = cc;
        }
        public int EngineSize
        {
            get { return cc; }
        }
        public string ModelProperty
        {
            get { return model; }
            set { model = value; }
        }
        //class private members - DO NOT TOUCH, unless you know what u are doing
        private string model;
        private readonly int cc;
        private const int maxSpeed = 10;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Car("avensis", 1895);
            Console.WriteLine("This toyota model is: " + toyota.ModelProperty);
            Console.WriteLine("This toyota engine size is: " + toyota.EngineSize);
            Console.ReadLine();
        }
    }
}
