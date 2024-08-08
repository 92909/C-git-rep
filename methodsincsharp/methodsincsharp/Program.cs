
using System;

namespace methodscsharp
{
    class methodsinc
    {
        static void myMethod()
        {
            Console.WriteLine("Kim Jackson");
        }
        // you can also add elements in the method
        static void myMethod2(string firstName)
        {
            Console.WriteLine($"My name is {firstName} Kimani");
        }
        // and even multiole ones
        static void myMethod3(string firName, string secName, int Age)
        {
            Console.WriteLine($"My name is {firName} {secName}. And I am {Age} years old");
        }
        // lets try sth
        static void myMethod4(string country = "Kenya")
        {
            Console.WriteLine(country);
        }
        // the return keyword
        static int myMethod5 (int x, int y)
        {
            int z = x + y;
            return x + y;
        }
        // lets try using static string
        static string myMethod6(string fname, string sname)
        {
            return fname + " " + sname;
            
        }
        // yiu can also name the arguments
        static void myKids(string kid1, string kid2)
        {
            Console.WriteLine($"The oldest is {kid2}");
        }
        static void Main(string[] args)
        {
            myMethod();
            myMethod();
            myMethod();
            
            myMethod2("Jackson");
            myMethod3("Wycliff", "Karanja", 22);
            myMethod4(); // If you dont enter a value, it took Kenya as its default value
            myMethod4("Edinburg");
            Console.WriteLine(myMethod5(20, 30));
            string z = myMethod6("Kim", "Jackson");
            Console.WriteLine(z);
            myKids(kid2: "Jack", kid1: "Sam");
        }
    }
}