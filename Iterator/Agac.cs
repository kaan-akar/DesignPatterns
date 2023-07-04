using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Agac : Aggregate
    {
        private int deger;
        public Agac sol;
        public Agac sag;
        public Agac(int d) 
        {
            deger = d;
            sol = null;
            sag = null;
        }

        public int degeriAl() { return deger; }

        public void solaEkle(Agac a) { sol = a; }
        public void sagaEkle(Agac a) { sag = a; }
        public override Iterator createIterator()
        {
            return new AgacIterator(this);
        }

    }
}
