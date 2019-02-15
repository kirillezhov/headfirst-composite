using Composite.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class MenuTestDrive
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu.Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu.Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu.Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu.Menu("DESSERT MENU", "Dessert of course!");

            MenuComponent allMenus = new Menu.Menu("ALL MENUS", "All menus combined");
            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);
            
            dinerMenu.Add(new MenuItem("Pasta", "Spaghetti with Marinara Sauce and a slice of sourdough bread", true, 3.89));
            dinerMenu.Add(new MenuItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99));
            dinerMenu.Add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99));
            dinerMenu.Add(new MenuItem("Soup of the day", "Soup of the day with a side of potato salad", false, 3.29));
            dinerMenu.Add(new MenuItem("Hotdog", "A hot dog with saurkraut, relish, onions, topped with cheese", false, 3.05));
            dinerMenu.Add(new MenuItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", true, 3.99));
            dinerMenu.Add(dessertMenu);

            cafeMenu.Add(new MenuItem("Soup of the day", "A cup pf the soup of the day with a side salad", false, 3.69));
            cafeMenu.Add(new MenuItem("Burrito", "A large burrito with whole pinto beans, salsa, guacamole", false, 4.29));
            cafeMenu.Add(new MenuItem("Veggie burger and air fries", "Veggie burger on a whole wheat bun, lettuce, tomato and fries", true, 3.99));

            pancakeHouseMenu.Add(new MenuItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99));
            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99));
            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49));
            pancakeHouseMenu.Add(new MenuItem("Waffles", "Waffles, with your choice of blueberries or strawberries", false, 3.59));

            dessertMenu.Add(new MenuItem("Apple Pie", "Apple Pie with a flakey crust topped with vanilla icecream", true, 1.59));

            Waitress waitress = new Waitress(allMenus);
            //waitress.PrintVegetarianMenu();

            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
