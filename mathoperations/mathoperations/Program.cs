using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(-41.7));//finds the absolute number
            Console.WriteLine(Math.Sqrt(49));//finds square root
            Console.WriteLine(Math.Round(-41.7));// this rounds up the number to the nearest whole number
            string name1 = "Wycliff Kimani Karanja"; // this operation also counts the spaces in the string
            Console.WriteLine($"The length of {name1} is : {name1.Length}");
            // we also have other operations
            Console.WriteLine(name1.ToUpper());
            // that applies to the lower case too
            Console.WriteLine(name1.ToLower());

            //lets move to the + operator
            string name2 = "Kim ";
            string name3 = "Jackson";
            Console.WriteLine(name2 + " " + name3);
            // you can also use the concatenate operator = concat
            string totalName = String.Concat(name2, name3);
            Console.WriteLine(totalName);

            // you can access items in a string
            Console.WriteLine(name3[1]);
            // you can also find the index location 
            Console.WriteLine(name3.IndexOf("J"));
            //you can use the Substring keyword to get 
            int position1 = name1.IndexOf("K");
            Console.WriteLine(name1.Substring(position1));
            // if you want to write a backslash, you use double backslashes
            Console.WriteLine("This \\ is called a backslash");
            // you can access items in a string
            Console.WriteLine(name3[1]);
            // you can also find the index location 
            Console.WriteLine(name3.IndexOf("J"));
            //you can use the Substring keyword to get 
            int position11 = name1.IndexOf("K");
            Console.WriteLine(name1.Substring(position11));
            // if you want to write a backslash, you use double backslashes
            Console.WriteLine("This \\ is called a backslash");
            // \b= backspace, \n=newline, \t=tab
            Console.WriteLine(100>90);


        }
    }
}