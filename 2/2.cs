using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args) //массив args
        {
            Console.WriteLine(args.Length); //вывод массива
            int a = Convert.ToInt32(args[0]); //переменная а типа int
            int b = Convert.ToInt32(args[1]); //переменная b типа int
            Console.WriteLine(a + b); //сумма значений переменных
        }
    }
}
