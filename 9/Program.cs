using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of letters");
            int numberOfLetters = int.Parse(Console.ReadLine());
            List<char> allLetters = new List<char>();

            for (int i = 0; i < numberOfLetters; i++)
            {
                Console.WriteLine("Enter the current letter");
                char currentChar = char.Parse(Console.ReadLine());
                allLetters.Add(currentChar);

            }

            

            Console.WriteLine("The letters in revers order are");

            allLetters.Reverse();

            Console.WriteLine(allLetters);

            //for (int i = numberOfLetters-1; i >= 0; i--)
            //{
                
            //    Console.WriteLine(allLetters[i]);
            //}
        }

    }
}
