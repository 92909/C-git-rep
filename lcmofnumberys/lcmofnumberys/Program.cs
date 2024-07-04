// See https://aka.ms/new-console-template for more information


using System;
namespace lcmoftwonumbers
{
    public class lcmofnumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a NumberA : ");
            int NumberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the NumberB : ");
            int NumberB = Convert.ToInt32(Console.ReadLine());

            int lcmnumbers = FindLCM(NumberA, NumberB);

            Console.Write("The LCM of the two numbers is : " + lcmnumbers);
        }
    }
}