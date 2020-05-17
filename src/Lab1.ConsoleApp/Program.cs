using System;

namespace Lab1.ConsoleApp
{
    class Program
    {
         static void Main(string[] args)
        {
            Square square = new Square();
            Circle circle = new Circle();
            circle.Set(5f);
            Console.WriteLine(circle.Area());
        }
    }
}
