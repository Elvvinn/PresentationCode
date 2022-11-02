using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] ededler = { 9, 50, 23, 34, 19 };
            int kicik, orta, boyuk, axtarilaneded = 19;
            kicik = 0;
            boyuk = ededler.Length - 1;

            while (kicik <= boyuk)
            {
                orta = (kicik + boyuk) / 2;
                if (axtarilaneded == ededler[orta])
                {
                    Console.WriteLine("ededimizin arrayin {0} . deyeri ", orta);
                    break;
                }

                else if (axtarilaneded < ededler[orta])
                {
                    boyuk = orta - 1;
                  
                }
                else
                {
                    kicik = orta + 1;
                    break;
                }
                Console.WriteLine(axtarilaneded);
              
            }
        }
    }
}