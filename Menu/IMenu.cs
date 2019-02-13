using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Menu
{
    interface IMenu
    {
        IEnumerator<MenuItem> CreateIterator();
    }
}
