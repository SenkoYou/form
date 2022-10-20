using System;

namespace form
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.3;
            double b = 0.9;
            double x = 0.61;


            Console.WriteLine("Входные значения:");
            Console.WriteLine($"Переменная a: {a}");
            Console.WriteLine($"Переменная b: {b}");
            Console.WriteLine($"Переменная x: {x}");



            double y = (Math.Pow(a, 2 * x) + Math.Pow(b, -x) * Math.Cos(a + b) * x) / (x + 1);
            Console.WriteLine("");
            Console.WriteLine($"Значение первого выражения y: {y}");




            double r = Math.Sqrt(Math.Pow(x,2) + b) - (Math.Pow(b,3)*Math.Sin(x+a))/x;
            Console.WriteLine("");
            Console.WriteLine($"Значение второго выражения d: {r}");
        }
    }
}
