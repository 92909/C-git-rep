// See https://aka.ms/new-console-template for more information

using System;

namespace declaringvariablestest
{
    class decvariables
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter your name1 : ");
            string name1 = Console.ReadLine ();

            Console.WriteLine("Enter your name2 : ");
            string name2 = Console.ReadLine();

            Console.WriteLine("Enter your Age : ");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your first name is " + name1 + " And your second one is " +  name2 + ". You are " + Age + "Years old");
        }
    }
}
