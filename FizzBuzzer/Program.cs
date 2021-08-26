using FizzBuzzLibrary;
using System;

namespace FizzBuzzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzzer!");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(new FizzBuzzLib().fizzbuzzer(i));
            }
            Console.ReadLine();
        }
    }
}
