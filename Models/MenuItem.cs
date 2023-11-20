using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment8.Models
{
    public class MenuItem(string name, string description, double price, bool isVeget)
    {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public double Price { get; set; } = price;
        public bool IsVegetarian { get; set; } = isVeget;
    }
}
