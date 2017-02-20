using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = Math.Abs(a - b);

            if (c < 0.000001m) 
            Console.WriteLine("true");
            else
            Console.WriteLine(false);
        }
    }
}
