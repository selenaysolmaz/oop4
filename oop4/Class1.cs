using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    public class Yazici
    {
        public void Yazdir (int i)
        {
            Console.WriteLine("sayisal degerler yazdiriliyor - {0}", i);
        }
        public void Yazdir(string s)
        {
            Console.WriteLine("metinsel değerler yazdırılıyor-{0}", s);
        }
    }
}
