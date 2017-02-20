using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexVariable = Console.ReadLine();
            int hexToInt = Convert.ToInt32(hexVariable, 16);
            Console.WriteLine(hexToInt);
        }
    }
}
