using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool inputTobool = Convert.ToBoolean(input);
            if(inputTobool == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
