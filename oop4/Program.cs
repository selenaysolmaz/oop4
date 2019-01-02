using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//çok biçimlilik örnek
namespace oop4
{
    class Program
    {
        static void Main(string[] args)
        {
            Yazici yazici = new Yazici();
            yazici.Yazdir("ayvansaray");
            yazici.Yazdir(2019);
            Console.WriteLine("işlem tamamlandı.");
            Console.ReadKey();

        }
    }
}
