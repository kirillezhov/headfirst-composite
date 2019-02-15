using Composite.MenuIterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Menu
{
    class MenuItem : MenuComponent
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

        public override string GetName() => name;
        public override string GetDescription() => description;
        public override bool IsVegetarian() => vegetarian;
        public override double GetPrice() => price;

        public override void Print()
        {
            Console.Write(" " + GetName());
            if (IsVegetarian())
            {
                Console.Write("(v)");
            }
            Console.WriteLine(", " + GetPrice());
            Console.WriteLine("   -- " + GetDescription());
        }

        public override IEnumerator<MenuComponent> CreateIterator()
        {
            return new NullIterator();
        }
    }
}
