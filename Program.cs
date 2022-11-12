using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int x = n, m = 0;
            while (x > 0)
            {
                m = m * 10 + x % 10;
                x /= 10;
            }
            if (m == n)
                Console.Write("{0} -> да", n);
            else
                Console.Write("{0} -> нет", n);
            Console.ReadKey();
        }
    }
}
