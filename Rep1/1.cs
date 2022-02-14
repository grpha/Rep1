using System;

namespace Rep1
{
    class MyHello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyHello");  //вывод текста
            string name; //переменная нейм типа стринг
            name = Console.ReadLine(); //переменной присваевается значение
            Console.WriteLine($"Привет, {name}"); //вывод
            Console.ReadKey();
        }
    }
}
