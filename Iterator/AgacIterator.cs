using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class AgacIterator : Iterator
    {
        Agac basla;
        Agac guncel;
        Stack<Agac> yigin;

        public AgacIterator(Agac a)
        {
            this.basla = a;
            this.yigin = new Stack<Agac>();
        }

        public override void First()
        {
            guncel = basla;
            yigin = new Stack<Agac>();
            yigin.Push(guncel);
        }

        public override void Next()
        {
            if (guncel.sag != null) { yigin.Push(guncel.sag); }
            if (guncel.sol != null) { yigin.Push(guncel.sol); }
        }

        public override bool IsDone()
        {
            return yigin.Count == 0;
        }

        public override int CurrentItem()
        {
            guncel = yigin.Pop();
            return guncel.degeriAl();
        }

    }
}
