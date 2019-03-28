using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFlyWeightPattern
{
    public  abstract class MenuItem
    {
        protected string Name;
        protected float Price;
        protected int Calories;

        public abstract void Display();

    }
}
