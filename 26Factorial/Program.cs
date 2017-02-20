using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _26Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger inputNum = BigInteger.Parse(Console.ReadLine());
            BigInteger fact = 1;

            for (BigInteger i = inputNum; i > 0; i--)
            {
                
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
