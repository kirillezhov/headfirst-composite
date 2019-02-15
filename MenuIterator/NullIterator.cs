using Composite.Menu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.MenuIterator
{
    class NullIterator : IEnumerator<MenuComponent>
    {
        public MenuComponent Current => throw new NotImplementedException();

        object IEnumerator.Current => null;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
