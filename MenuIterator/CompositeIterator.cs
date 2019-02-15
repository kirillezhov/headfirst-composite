using Composite.Menu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.MenuIterator
{
    class CompositeIterator : IEnumerator<MenuComponent>
    {
        Stack<IEnumerator<MenuComponent>> stack = new Stack<IEnumerator<MenuComponent>>();

        public CompositeIterator(IEnumerator<MenuComponent> iterator)
        {
            stack.Push(iterator);
        }

        object IEnumerator.Current => Current;

        public MenuComponent Current
        {
            get
            {
                if (MoveNext())
                {
                    IEnumerator<MenuComponent> iterator = stack.Peek();
                    MenuComponent component = iterator.Current;

                    stack.Push(component.CreateIterator());
                    return component;
                }
                else
                {
                    return null;
                }
            }
        }

        public bool MoveNext()
        {
            if(stack.Count == 0)
            {
                return false;
            }
            else
            {
                IEnumerator<MenuComponent> iterator = stack.Peek();
                if (!iterator.MoveNext())
                {
                    stack.Pop();
                    return MoveNext();
                }
                else
                {
                    return true;
                }
            }
        }

        public void Reset() => throw new InvalidOperationException();
        public void Dispose() => throw new InvalidOperationException();
    }
}
