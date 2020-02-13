using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLoop
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int asdf = 0; asdf <= 100; asdf++)
            {
                if (asdf == 0)
                {
                    Console.WriteLine("0");
                }
                else if (asdf % 5 == 0 && asdf % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(asdf % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (asdf % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(asdf);
                }
            }

            Console.ReadLine();

        }
    }
}
