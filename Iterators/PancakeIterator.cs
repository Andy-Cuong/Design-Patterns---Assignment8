using Design_Patterns___Assignment8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment8.Iterators
{
    public class PancakeIterator : IMenuItemIterator
    {
        private List<MenuItem> _items;
        private int _index = 0;

        // Pass the array into the constructor
        public PancakeIterator(List<MenuItem> items) 
        { 
            _items = items;
        }

        // Return true if there is at least one item left
        public bool HasNext()
        {
            if (_index >= _items.Count) return false;
            else return true;
        }

        public MenuItem Next()
        {
            MenuItem menuItem = _items[_index];
            _index++;
            return menuItem;
        }
    }
}
