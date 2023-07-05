using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    abstract class Component
    {
        public Component() { }

        public abstract string Operation();

        public virtual void Add(Component component) 
        {
        
        }

        public virtual void Remove(Component component) 
        {
            
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
