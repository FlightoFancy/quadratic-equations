using System;
using System.IO;
using Xunit;

namespace quadratic_equations.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using var sw = new StringWriter();
            string Expected = "Дискриминант больше нуля. Первый корень равен 5. Второй корень равен -1";
            Console.SetOut(sw);
            QuadraticEquation quadraticEquationTest1 = new();
            quadraticEquationTest1.SolutionQuadraticEquation(1, -4, -5);
            var result = sw.ToString().Trim();
            Assert.Equal(Expected, result);
        }

        [Fact]
        public void Test2()
        {
            using var sw = new StringWriter();
            string Expected = "Дискриминант меньше нуля. Корней нет";
            Console.SetOut(sw);
            QuadraticEquation quadraticEquationTest2 = new();
            quadraticEquationTest2.SolutionQuadraticEquation(3, -4, 2);
            var result = sw.ToString().Trim();
            Assert.Equal(Expected, result);
        }
        [Fact]
        public void Test3()
        {
            using var sw = new StringWriter();
            string Expected = "Дискриминант равен нулю. Корень равен 3";
            Console.SetOut(sw);
            QuadraticEquation quadraticEquationTest3 = new();
            quadraticEquationTest3.SolutionQuadraticEquation(1, -6, 9);
            var result = sw.ToString().Trim();
            Assert.Equal(Expected, result);
        }

    }
}

