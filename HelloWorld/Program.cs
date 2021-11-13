using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you name?");
            string UserName;
            UserName = Console.ReadLine();


            Console.WriteLine("Hello, " + UserName);



            Console.Read();
            
        }
    }
}
