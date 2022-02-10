using System;

namespace Rep1
{
    class MyHello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyHello");
            string name;
            name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
            Console.ReadKey();
        }
    }
}
