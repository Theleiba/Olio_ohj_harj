using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio2
{
    class Car
    {
        public string ModelProperty
        {
            get { return model; }
            set
            {
                if (value == "corolla" || value == "avensis")
                {
                    model = value;
                }
                else
                {
                    model = "unknown";
                }
            }
        }
        //class private members - DO NOT TOUCH, unless you know what you are doing
        private string model;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Car();
            toyota.ModelProperty = "911";

            Console.WriteLine("This toyota model is: " + toyota.ModelProperty);
            Console.ReadLine();
        }
    }
}
