using System;
using Xunit;
using Lab1.ConsoleApp;

namespace Lab1.Tests
{
    public class UnitTest1
    {
       [Fact]
        public void Test1()
        {
            Square square = new Square();
            square.Set(5f);
            Assert.Equal(25f, square.Area());
            Assert.Equal(20f, square.Perimeter());

        }
        [Fact]
        public void Test2()
        {
            Circle circle = new Circle();
            circle.Set(5f);
            Assert.Equal(78.5f, circle.Area());
            Assert.Equal(31.400002f, circle.Perimeter());

        }
        [Fact]
        public void Test3()
        {
            Triangle triangle = new Triangle();
            triangle.Set(4f);
            Assert.Equal(6.92f, triangle.Area());
            Assert.Equal(12f, triangle.Perimeter());

        }
    }
}
