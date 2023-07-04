using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public abstract class Iterator
    {
        public abstract void First();
        public abstract void Next();
        public abstract Boolean IsDone();
        public abstract int CurrentItem();

    }
}
