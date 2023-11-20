using Design_Patterns___Assignment8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment8.Iterators
{
    public class DinerIterator : IMenuItemIterator
    {
        private MenuItem[] _items;
        private int _index = 0;

        // Pass the collection into the constructor
        public DinerIterator(MenuItem[] items)
        {
            _items = items;
        }

        // Return true if there is at least one item left AND it is not null
        public bool HasNext()
        {
            if (_index >= _items.Length || _items[_index] == null) return false;
            else return true;
        }

        public MenuItem Next()
        {
            MenuItem item = _items[_index];
            _index++;
            return item;
        }
    }
}
