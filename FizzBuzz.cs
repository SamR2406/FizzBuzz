using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz 

    /* Create a for loop from 1 to 100
     * 3 and 5 = Buzz
     * 3 = Fizz
     * 5 = Buzz
     * else = number
    */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool threeDiv = false;
            bool fiveDiv= false;

            for (int i = 1; i<=100; i++)
            {
                threeDiv = i % 3 ==0;
                fiveDiv = i % 5 ==0;

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }

                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                    
                else
                {
                    Console.WriteLine(i);
                }

                


            }



        }
    }
}
