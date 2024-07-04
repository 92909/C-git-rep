
using System;

namespace ifelseoperations
{
    class ifelseoperators
    {
        static void Main(string[] args)
        {
            //this is a program to check ones eligibility to vote
            Console.WriteLine("Enter your Age : ");
            int Age = Convert.ToInt32(Console.ReadLine());

            if (Age > 18)
            {
                Console.WriteLine($"You are {Age} years old. You are eligible to vote!");
            }
            else if (Age == 18)
            {
                Console.WriteLine($"You are {Age} years old and eligible to vote!");
            }
            else
            {
                Console.WriteLine($"You are {Age} years old. You are not eligible to vote!");
            }

            // lets move to switch statemets - to find the name given to a certain day of the week
            Console.WriteLine("There are 7 days in a week. Which one do you wish to know the name. Integers only");
            Console.WriteLine("Enter the day of the week : ");

            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("The number you entered is incorrect");
                    break ;
            }
        }
    }
}