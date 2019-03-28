using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFlyWeightPattern
{
    //Concrete flyweight class
    public class CiderBakedHam : MenuItem
    {
        public CiderBakedHam()
        {
            Name = "Cider Baked Ham";
            Price = 16.00f;
            Calories = 1000;
        }

        public override void Display()
        {
            Console.WriteLine($"{Name},{Price},{Calories}");
        }
    }
}
