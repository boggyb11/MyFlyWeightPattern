using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFlyWeightPattern
{
    //flyweight factory class
    class MealFactory
    {
        private Dictionary<char, MenuItem> _menuItems = new Dictionary<char, MenuItem>();

        public MenuItem GetMenuItem(char key)
        {
            MenuItem menuItem = null;
            if (_menuItems.ContainsKey(key))
            {
                menuItem = _menuItems[key];
            }
            else
            {
                switch (key)
                {
                    case 'a' : menuItem = new CiderBakedHam();break;
                    case 's' : menuItem = new Steak(); break;
                    case 'd' : menuItem = new FishAndChips(); break;
                }
                _menuItems.Add(key, menuItem);
            }

            return menuItem;
        }
    }
}
