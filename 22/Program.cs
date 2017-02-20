using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbercount = int.Parse(Console.ReadLine());

            int firstNum = 1;
            int secondNum = 1;
            int sum = 1;

            Console.WriteLine(firstNum);
            for (int i = numbercount-2; i >= 0; i--)
            {
                sum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = sum;
                Console.WriteLine(firstNum);
            }
            Console.WriteLine(sum);
            Console.WriteLine();
        }
    }
}
