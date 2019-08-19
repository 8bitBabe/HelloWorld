using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //Prints out "Hello, World!" then pauses until the user presses a key.
            //The program then closes. 
            //Console.WriteLine("Hello, World!");
            //Console.Write("Press any key to continue...");
            //Console.ReadKey(true);


            //Displays prompt for user's name, then returns the answer
            //in an interpolated string (the "$" character)
            //with current date and time from the DateTime.Now property
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"Hello, {name}, on {date:d} at {date:t}!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);


        }
    }
}
