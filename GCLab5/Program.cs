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
            bool again = true;
            do {
            Console.Write("Give me a number between 1 and 25:");
            int input = 0;
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("you didnt put in a number");
                }
                if (input <= 25)
                {
                    long output = 1;
                    for (int i = 2; i <= input; i++)
                    {
                        output *= i;
                    }
                    Console.WriteLine(output);

                    Console.Write("Again? (Y/N)");
                    string go = Console.ReadLine();
                    if (go.ToLower() != "y")
                    {
                        again = false;
                    }
                
                }
            } while (again) ;
        }
    }
}
