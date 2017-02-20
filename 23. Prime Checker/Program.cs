using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long inputNum = long.Parse(Console.ReadLine());
            IsPrime(inputNum);

        }
        static void IsPrime(long inputNum)
        {
            bool isPrime = true;
            double maxDevider = Math.Sqrt(inputNum);

            if (inputNum == 0 || inputNum == 1)
                isPrime = false;

            for (int i = 2; i <= maxDevider; i++)
            {
                if(inputNum % i == 0)
                {
                    isPrime = false;
                    break;
                }   
            }
            Console.WriteLine(isPrime);
        }
    }
}
