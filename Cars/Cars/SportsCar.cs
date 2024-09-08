using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class SportsCar : Car
    {
        public SportsCar(string brand, string model, int horsepower) : base(brand, model)
        {
            hp = horsepower; // use the inherited 'hp' property from the Engine class
        }
        public override void Rev() // Override the functionality to just printing in the console
        {
            Console.WriteLine("VROOM VROOM");
        }
    }
}
