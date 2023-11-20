using Design_Patterns___Assignment8.Iterators;
using Design_Patterns___Assignment8.Menus;
using Design_Patterns___Assignment8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment8.Waitresses
{
    public class Waitress
    {
        private IMenu _pancakeMenu;
        private IMenu _dinerMenu;

        public Waitress(IMenu pancakeMenu, IMenu dinerMenu)
        {
            _pancakeMenu = pancakeMenu;
            _dinerMenu = dinerMenu;
        }

        public void printMenu()
        {
            // Retrieve the iterators
            IMenuItemIterator pancakeIterator = _pancakeMenu.createIterator();
            IMenuItemIterator dinerIterator = _dinerMenu.createIterator();

            // Print the pancake menu
            Console.WriteLine("\n|||||||| BREAKFAST ||||||||");
            iterate(pancakeIterator);

            // Print the diner menu
            Console.WriteLine("\n|||||||| DINER ||||||||");
            iterate(dinerIterator);
        }

        private void iterate(IMenuItemIterator iter)
        {
            // Loop until the end of the collection
            while (iter.HasNext())
            {
                // Print the each menu item
                MenuItem item = iter.Next();
                Console.WriteLine($"{item.Name}, {item.Description}. Price: {item.Price}. " +
                    $"{(item.IsVegetarian ? "v" : "")}");
            }
        }
    }
}
