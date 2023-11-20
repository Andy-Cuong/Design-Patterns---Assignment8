using Design_Patterns___Assignment8.Iterators;
using Design_Patterns___Assignment8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment8.Menus
{
    public class DinerMenu : IMenu
    {
        // Keep track of the maximum number of items in the menu
        private int _itemIndex = 0;
        private const int MaxItems = 5;
        private MenuItem[] _menuItems = new MenuItem[MaxItems];

        public DinerMenu() 
        {
            addItem(new MenuItem("Green rice with grilled beef", "Best seller", 5.99, false));
            addItem(new MenuItem("Vessie chicken", "French style chicken", 6.79, false));
            addItem(new MenuItem("Vegetable soup", "A light soup bowl with mixed vegetable", 3.99, true));
            addItem(new MenuItem("Almond tofu", "Chinese style snack", 4.99, true));
        }

        // Add menu item, if the menu still has vacant slot
        public void addItem(MenuItem item)
        {
            if (_itemIndex >= MaxItems)
            {
                Console.WriteLine("Sorry, no more slots in menu");
                return;
            }
            else
            {
                _menuItems[_itemIndex] = item;
                _itemIndex++;
            }
        }

        public IMenuItemIterator createIterator()
        {
            return new DinerIterator(_menuItems);
        }
    }
}
