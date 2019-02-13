using Iterator.Menu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.MenuIterator
{
    class DinerMenuIterator : IEnumerator<MenuItem>
    {
        MenuItem[] menuItems;
        int position = -1;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            this.menuItems = menuItems;
        }

        object IEnumerator.Current => Current;

        public MenuItem Current
        {
            get
            {
                try
                {
                    return menuItems[position];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < menuItems.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            throw new InvalidOperationException();
        }
    }
}
