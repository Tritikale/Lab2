using System;
namespace Lab1.ConsoleApp
{
public class Triangle : Figure{

    /// <summary>
    /// Calculates Area
    /// </summary>
    /// <returns></returns>
    public override float Area(){
        return (edge * edge * 1.73f / 4f);
    }

    /// <summary>
    /// Calculates Perimeter
    /// </summary>
    /// <returns></returns> 
    public override float Perimeter(){
        return (edge * 3f);
    }

 }
}