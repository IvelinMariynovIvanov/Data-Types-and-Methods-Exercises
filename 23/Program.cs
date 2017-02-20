using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            double maxDevider = Math.Sqrt(num);

            if (num == 0 || num == 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < maxDevider; i++)
                {
                    if(num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isPrime);
            Console.WriteLine();
        }
    }
}
