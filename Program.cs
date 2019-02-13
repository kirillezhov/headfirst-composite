using Iterator.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class MenuTestDrive
    {
        static void Main(string[] args)
        {
            IMenu pancakeHouseMenu = new PancakeHouseMenu();
            IMenu dinerMenu = new DinerMenu();
            IMenu cafeMenu = new CafeMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);
            waitress.PrintMenu();
        }
    }
}
