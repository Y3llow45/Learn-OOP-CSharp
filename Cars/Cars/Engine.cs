using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Engine
    {
        public int hp { get; set; } // public property
        private int _id {get;set; } // encapsulated field for internal use. Property isn't inherited
        public int Mileage { get; private set; } // Millage can be set only in the Engine class because of "private set"

        public Engine() // main method Engine generates unique _id
        {
            _id = GenerateEngineId();
            Mileage = 0;
        }

        private int GenerateEngineId()
        {
            return new Random().Next(1000, 9999); // random ID generator
        }

        public int GetEngineId() // controlled access to _id
        {
            return _id;
        }
        public virtual void Rev() // simple method. Virutal allows the method to be ovveriden
        {
            Console.WriteLine("wrom wrom");
            Mileage += 10000; // Add 10k to mileage when Rev is called

            // Check if mileage exceeds 30k
            if (Mileage > 30000)
            {
                Console.WriteLine("Visit service!");
            }
        }
    }
}
