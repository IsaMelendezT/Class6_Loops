using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Class6_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class Exercise
            Console.WriteLine("--------------------- Exercise 1 -----------------------");
            
            // Creating the variable to host the user input
            int num = 0;

            // Use a DoWhile loop until the user enter a correct number (below 10)
            do
            {
                Console.WriteLine("Please enter a number below 10: ");
                num = int.Parse(Console.ReadLine());

            } while (num > 10);

            Console.WriteLine("n = " + num);

            // For loop to print the times table
            for (int i = 1; i < 10; i++) {

                Console.WriteLine("{0} * {1} = {2}", i, num, i * num);
            }



        }
    }
}
