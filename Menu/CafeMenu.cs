using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Menu
{
    class CafeMenu : IMenu
    {
        Dictionary<string, MenuItem> menuItems;

        public CafeMenu()
        {
            menuItems = new Dictionary<string, MenuItem>();

            AddItem("Soup of the day", "A cup pf the soup of the day with a side salad", false, 3.69);
            AddItem("Burrito", "A large burrito with whole pinto beans, salsa, guacamole", false, 4.29);
            AddItem("Veggie burger and air fries", "Veggie burger on a whole wheat bun, lettuce, tomato and fries", true, 3.99);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem.GetName(), menuItem);
        }

        public IEnumerator<MenuItem> CreateIterator()
        {
            return menuItems.Values.GetEnumerator();
        }
    }
}
