using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFlyWeightPattern
{
    //concrete flyweight class
    public class Steak : MenuItem
    {
        public Steak()
        {
            Name = "Steak";
            Price = 22.00f;
            Calories = 900;
        }

        public override void Display()
        {
            Console.WriteLine($"{Name},{Price},{Calories}");
        }
    }
}
