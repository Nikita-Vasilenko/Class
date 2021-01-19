using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите число b:");
            double b = double.Parse(Console.ReadLine());
            Chicla chicla = new Chicla(a, b);
            chicla.Print();
            Console.ReadKey();
        }
    }
}
