﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Menu
{
    abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent) => throw new InvalidOperationException();
        public virtual void Remove(MenuComponent menuComponent) => throw new InvalidOperationException();
        public virtual MenuComponent GetChild(int i) => throw new InvalidOperationException();

        public virtual string GetName() => throw new InvalidOperationException();
        public virtual string GetDescription() => throw new InvalidOperationException();
        public virtual double GetPrice() => throw new InvalidOperationException();
        public virtual bool IsVegetarian() => throw new InvalidOperationException();

        public virtual void Print() => throw new InvalidOperationException();
        public abstract IEnumerator<MenuComponent> CreateIterator();
    }
}
