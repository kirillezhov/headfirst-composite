using Composite.Menu;
using Composite.MenuIterator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Waitress
    {
        MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void PrintMenu()
        {
            allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            IEnumerator<MenuComponent> enumerator = allMenus.CreateIterator();
            Console.WriteLine("\r\nVEGETARIAN MENU\r\n----");
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = enumerator.Current;

                if(menuComponent is MenuItem)
                {
                    if (menuComponent.IsVegetarian())
                    {
                        menuComponent.Print();
                    }
                }

                //try
                //{
                //    if (menuComponent.IsVegetarian())
                //    {
                //        menuComponent.Print();
                //    }
                //}
                //catch(InvalidOperationException){ }
            }
        }
    }
}
