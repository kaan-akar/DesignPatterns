using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Listeleme.Listele(new Dizi());

            Agac agac = new Agac(12);
            Agac sag = new Agac(13);
            Agac sol = new Agac(15);
            Agac sag2 = new Agac(20);

            agac.solaEkle(sol);
            agac.sagaEkle(sag);
            sag.sagaEkle(sag2);

            Listeleme.Listele(agac);

        }
    }
}
