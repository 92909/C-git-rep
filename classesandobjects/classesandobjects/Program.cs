// See https://aka.ms/new-console-template for more information

namespace classes
{
    public class Person
    {
        public string Name;
        public int Age;
        public bool hasID;

        public void Greeting()
        {
            Console.WriteLine($"Hi. My name is {Name}.  And My age is { Age}");
        }
    }

   
}