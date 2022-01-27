using System;

namespace quadratic_equations
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    if (a == 0)
                    {
                        Console.WriteLine("Коэффициент а не может быть равен 0");
                        continue;
                    }
                    Console.WriteLine("Введите значение b");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение c");
                    c = Convert.ToDouble(Console.ReadLine());
                    QuadraticEquation quadraticEquation = new();
                    quadraticEquation.SolutionQuadraticEquation(a, b, c);
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Исключение: {ex.Message}");
                }
            }
        }
    }

}
