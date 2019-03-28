using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFlyWeightPattern
{
    //concrete flyweight class
    public class FishAndChips : MenuItem
    {
        public FishAndChips()
        {
            Name = "Fish and Chips";
            Price = 15.00f;
            Calories = 750;
        }

        public override void Display()
        {
            Console.WriteLine($"{Name},{Price},{Calories}");
        }
    }
}
