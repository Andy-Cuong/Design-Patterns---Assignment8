using Design_Patterns___Assignment8.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment8.Menus
{
    // The interface the waitress will use to iterate through the menu items
    public interface IMenu
    {
        IMenuItemIterator createIterator();
    }
}
