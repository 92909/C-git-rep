//Console.WriteLine("My name is Kim Jackson");

using System;

namespace helloWorld
{
    class hellowrld
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Networth: ");
            int Networth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your wife NetworthA : ");
            int NetworthA = Convert.ToInt32(Console.ReadLine());
            
            int totalNetworth = Networth + NetworthA;

            Console.WriteLine("Your networth is " + Networth + "And your wife's networth is " + NetworthA);
            Console.WriteLine("Your family's Networth is : " + totalNetworth);
            Console.WriteLine(totalNetworth.GetType());
            string tNetworth = Convert.ToString(totalNetworth);
            Console.WriteLine(tNetworth.GetType());
            Console.ReadKey();
            // to differentiate between char and strings, strings are stored or written in double quotes 
            // while char are written in single quote
        }
    }
}