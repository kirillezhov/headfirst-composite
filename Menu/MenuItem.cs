using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Menu
{
    class MenuItem
    {
        string name, description;
        bool vegetarian;
        double price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public string GetName() => name;
        public string GetDescription() => description;
        public bool IsVegetarian() => vegetarian;
        public double GetPrice() => price;
    }
}
