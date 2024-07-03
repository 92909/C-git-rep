// See https://aka.ms/new-console-template for more information
using System;

namespace firstProgram
{
    class program1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your valueA : ");
            int valueA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your valueB : ");
            int valueB = Convert.ToInt32(Console.ReadLine());

            int sumT = valueA + valueB; 
            Console.ReadLine();
            Console.Write("Your age is : " + sumT);
        }
    }
}
