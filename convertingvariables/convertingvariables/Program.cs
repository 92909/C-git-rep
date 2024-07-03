

using System;

namespace convertvars
{
    class convVariables
    {
        static void Main (string[] args)
        {
            double a = 3.14;
            
            int b = Convert.ToInt32(a);
            int z = b * b;
            double c = a * a;

            Console.WriteLine(a);
            Console.WriteLine(z);
            Console.WriteLine(c);
        }
    }
}