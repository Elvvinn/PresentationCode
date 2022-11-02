using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] ededler  = new int[5] { 8, 10, 20, 30, 40 };
            int axtarilaneded = 10;
            for (int i = 0; i < ededler.Length; i++)
            {
                if (ededler[i]==axtarilaneded)
                {
                    Console.WriteLine("Axtardigimiz eded :" +axtarilaneded);
                    
                }
            }

        }
    }
}
