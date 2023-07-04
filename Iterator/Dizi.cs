using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Dizi : Aggregate
    {
        public List<int> liste;
        public Dizi() {
            liste = new List<int>();
            liste.Add(1);liste.Add(3);liste.Add(6);
            liste.Add(5);liste.Add(2);liste.Add(4);
        }

        public override Iterator createIterator()
        {
            return new DiziIterator(this);
        }
    } 
}
