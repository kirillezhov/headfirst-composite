using Iterator.Menu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.MenuIterator
{
    class AlternatingDinerMenuIterator : IEnumerator<MenuItem>
    {
        MenuItem[] items;
        int position;

        public AlternatingDinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
            position = (int)DateTime.Now.DayOfWeek % 2;
        }

        object IEnumerator.Current => Current;

        public MenuItem Current
        {
            get
            {
                try
                {
                    return items[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position += 2;
            return (position < items.Length);
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
