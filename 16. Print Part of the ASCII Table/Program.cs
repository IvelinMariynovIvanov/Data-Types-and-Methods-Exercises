using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputMinValue = int.Parse(Console.ReadLine());
            int inputMaxValue = int.Parse(Console.ReadLine());

            for (int i = inputMinValue; i <= inputMaxValue; i++)
            {
                char symbol = (char)(i);
                Console.Write(symbol);
                Console.Write(" ");
                
            }
            Console.WriteLine();
        }
    }
}
