using Design_Patterns___Assignment8.Iterators;
using Design_Patterns___Assignment8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment8.Menus
{
    public class PancakeMenu : IMenu
    {
        // Flexibly adding items to or removing items from the menu
        private List<MenuItem> _menuItems = new List<MenuItem>();

        public PancakeMenu() 
        {
            addItem(new MenuItem("Traditional pancake", "The most original one", 1.99, false));
            addItem(new MenuItem("Fruit pancake", "With fruit syrup and milk", 2.49, true));
            addItem(new MenuItem("Extra thicc pancake", "With scrambled egg, toast, and sausage", 3.39, false));
            addItem(new MenuItem("Pancake for minor", "Nice and soft", 1.49, true));
        }

        public void addItem(MenuItem item)
        {
            _menuItems.Add(item);
        }

        public IMenuItemIterator createIterator()
        {
            return new PancakeIterator(_menuItems);
        }
    }
}
