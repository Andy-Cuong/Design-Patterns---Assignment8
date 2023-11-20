using Design_Patterns___Assignment8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment8.Iterators
{
    public interface IMenuItemIterator
    {
        // Check if the collection has any item left
        bool HasNext();
        
        // Return the next item
        MenuItem Next();
    }
}
