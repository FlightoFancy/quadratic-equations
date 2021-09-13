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
            SolutionQuadraticEquation.QuadraticSolver(a, b, c);
            Console.ReadKey();
            Console.Clear();
            }
              catch(Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
            }
        }
    }
    public class SolutionQuadraticEquation
    {
        public static void QuadraticSolver(double a, double b, double c)
        {
            double disc = FindDiscriminant(a, b, c);
            if (disc < 0)
            {
               DiscriminantLessZero();
            }
            else if (disc == 0)
            {
               DiscriminantIsZero(a, b);
            }
            else
            {
               DiscriminantMoreZero(a, b, disc);
            }
        }
        private static double FindDiscriminant(double a, double b, double c)
        {
            double dis = (b * b) - (4 * a * c);
            return dis;
        }
        private static void DiscriminantLessZero()
        {
            Console.WriteLine("Дискриминант меньше нуля. Корней нет");
        }
        private static void DiscriminantIsZero(double a, double b)
        {
            double x = (-b / (2 * a));
            Console.WriteLine($"Дискриминант равен нулю. Корень равен {x}");
        }
        private static void DiscriminantMoreZero(double a, double b, double disc)
        {
            double x1 = ((-b + Math.Sqrt(disc)) / (2 * a));
            double x2 = ((-b - Math.Sqrt(disc)) / (2 * a));
            Console.WriteLine($"Дискриминант больше нуля. Первый корень равен {x1}. Второй корень равен {x2}");
        }
    }
}
