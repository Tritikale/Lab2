using System;

namespace Lab1.ConsoleApp
{
public class Circle : Figure{
    /// <summary>
    /// Calculates Area
    /// </summary>
    /// <returns></returns>
    public override float Area(){
        return (edge * edge * 3.14f);
    }

    /// <summary>
    /// Calculates Perimeter
    /// </summary>
    /// <returns></returns>
    public override float Perimeter(){
        return (edge * 2f * 3.14f);
    }
}
}