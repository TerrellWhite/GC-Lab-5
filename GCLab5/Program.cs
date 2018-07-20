using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab5
{
    class Program
    {
        static void Main(string[] args)//calculate the factorial of a number
        {
            Console.Write("Give me a number:");
            int input = int.Parse(Console.ReadLine());
            long output = 1;
            for (int i = 2; i <= input; i++)
            {
               output *= i;
            }
            Console.WriteLine(output);
        }
    }
}
