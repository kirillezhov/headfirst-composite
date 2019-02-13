using Iterator.Menu;
using Iterator.MenuIterator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Waitress
    {
        IMenu pancakeHouseMenu, dinerMenu, cafeMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
            this.cafeMenu = cafeMenu;
        }

        public void PrintMenu()
        {
            IEnumerator<MenuItem> pancakeIterator = pancakeHouseMenu.CreateIterator();
            IEnumerator<MenuItem> dinerIterator = dinerMenu.CreateIterator();
            IEnumerator<MenuItem> cafeIterator = cafeMenu.CreateIterator();
            Console.WriteLine("MENU\r\n----\r\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\r\nLUNCH");
            PrintMenu(dinerIterator);
            Console.WriteLine("\r\nDINNER");
            PrintMenu(cafeIterator);
        }

        private void PrintMenu(IEnumerator<MenuItem> iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = iterator.Current;
                Console.Write(menuItem.GetName() + ", ");
                Console.Write(menuItem.GetPrice() + " -- ");
                Console.WriteLine(menuItem.GetDescription());
            }
        }
    }
}
