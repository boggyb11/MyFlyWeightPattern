using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFlyWeightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your menu order (use a,s,d with no space)");
            var order = Console.ReadLine();
            var chars = order.ToCharArray();

            MealFactory mealFactory = new MealFactory();

            foreach (var character  in order)
            {
                MenuItem item = mealFactory.GetMenuItem(character);
                item.Display();
            }

            Console.ReadKey();
        }
    }
}
