using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car : Engine
    {
        public string? Brand { get; set; }  // public property
        public string? Model { get; set; }  // public property

        public Car(string brand, string model)  // constructor that sets brand and model
        {
            Brand = brand;
            Model = model;
        }
    }
}
