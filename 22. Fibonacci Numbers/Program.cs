using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            FibonaciNumber(numberCount);
        }

        static void FibonaciNumber(int numberCount)
        {
            int firstfibonaciNumber = 1;
            int secondfibonaciNumber = 1;
            int sum = 1;

            for (int i = numberCount-2; i >= 0; i--)
            {
                sum = firstfibonaciNumber + secondfibonaciNumber;
                firstfibonaciNumber = secondfibonaciNumber;
                secondfibonaciNumber = sum;
            
            }
            Console.WriteLine(sum);
        }
    }
}
