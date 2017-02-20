using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = GetMax(a, b);
            int realMax = GetMax(max, c);
            Console.WriteLine(realMax);

            
        }

        static int GetMax( int a, int b)
        {

            if (a > b)
            {
                //Console.WriteLine(a);
                return a;
            }
            else
            {
               // Console.WriteLine(b);
                return b;
            }

        }
    }
}
