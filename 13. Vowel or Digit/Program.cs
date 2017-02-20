using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

                switch (input)
                {
                    case '1':
                    case '2': 
                    case '3': 
                    case '4': 
                    case '5': 
                    case '6': 
                    case '7': 
                    case '8': 
                    case '9': 
                    case '0':
                    Console.WriteLine("digit");
                    break;

                    case 'a':
                    case 'o':
                    case 'i':
                    case 'e':
                    case 'u':
                    Console.WriteLine("vowel");
                    break;

                default:
                    Console.WriteLine("other");
                    break;
                }
        }
    }
}
