
using System;
namespace loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            
            // you can also use do/while loop
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 10);
            

            // for loop
            
            for (int k =  0; k < 10; k++)
            {
                Console.WriteLine($"Name : {k}");
                // lets talk nested loops
                for (int m = 0;  m < 10; m++)
                {
                    Console.WriteLine($"Second name : {m}");
                }

            }


        }
    }
}
