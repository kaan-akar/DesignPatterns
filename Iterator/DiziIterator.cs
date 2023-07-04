using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class DiziIterator : Iterator
    {
        private Dizi dizi;
        private int idx;

        public DiziIterator(Dizi d)
        {
            dizi = d;
            idx = 0;
        }

        public override void First()
        {
            idx = 0;
        }

        public override void Next()
        {
            idx++;
        }

        public override bool IsDone()
        {
            return idx == dizi.liste.Count;
        }


        public override int CurrentItem()
        {
            return dizi.liste.ElementAt(idx);
        }

    }
}
