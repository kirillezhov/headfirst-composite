using Composite.MenuIterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Menu
{
    class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        string name, description;
        IEnumerator<MenuComponent> enumerator = null;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Add(MenuComponent menuComponent) => menuComponents.Add(menuComponent);
        public override void Remove(MenuComponent menuComponent) => menuComponents.Remove(menuComponent);
        public override MenuComponent GetChild(int i) => menuComponents[i];
        public override string GetName() => name;
        public override string GetDescription() => description;
        public override void Print()
        {
            Console.Write("\r\n" + GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("---------------------");

            IEnumerator<MenuComponent> iterator = menuComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = iterator.Current;
                menuComponent.Print();
            }
        }

        public override IEnumerator<MenuComponent> CreateIterator()
        {
            if(enumerator == null)
            {
                enumerator = new CompositeIterator(menuComponents.GetEnumerator());
            }
            return enumerator;
        }
    }
}
