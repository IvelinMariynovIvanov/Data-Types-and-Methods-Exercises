using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string inputNumber= Console.ReadLine();

            NumbersInReversedOrder(inputNumber);

        }

        static void NumbersInReversedOrder(string inputNumber)
        {
            for (int i = inputNumber.Length-1; i >= 0; i--)
            {
                Console.Write(inputNumber[i]);
               
            }
            Console.WriteLine();
        }
    }
}
