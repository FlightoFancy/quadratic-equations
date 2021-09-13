using System;
using Xunit;
using System.IO;

namespace TestProject
{
    public class UnitTestQuadraticEquations
    {
        
        [Fact]
        public void Test1()
        {
            using var sw = new StringWriter();
            string Expected = "������������ ������ ����. ������ ������ ����� 5. ������ ������ ����� -1";
            Console.SetOut(sw);
            quadratic_equations.SolutionQuadraticEquation.QuadraticSolver(1, -4, -5);
            var result = sw.ToString().Trim();
            Assert.Equal(Expected, result);
        }

        [Fact]
        public void Test2()
        {
            using var sw = new StringWriter();
            string Expected = "������������ ������ ����. ������ ���";
            Console.SetOut(sw);
            quadratic_equations.SolutionQuadraticEquation.QuadraticSolver(3, -4, 2);
            var result = sw.ToString().Trim();
            Assert.Equal(Expected, result);
        }
        [Fact]
        public void Test3()
        {
            using var sw = new StringWriter();
            string Expected = "������������ ����� ����. ������ ����� 3";
            Console.SetOut(sw);
            quadratic_equations.SolutionQuadraticEquation.QuadraticSolver(1, -6, 9);
            var result = sw.ToString().Trim();
            Assert.Equal(Expected, result);
        }

    }
}