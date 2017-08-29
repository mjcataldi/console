using System;
using static System.Console;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World! How are you?");
            string response = ReadLine();

            // string[] ResponseArray = response.Split();

            WriteLine($"You responded '{ response }', so I hope that means you're ok!");

        }
    }
}
