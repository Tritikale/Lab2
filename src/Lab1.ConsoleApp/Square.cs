using System;
namespace Lab1.ConsoleApp
{
public class Square : Figure{

    /// <summary>
    /// Calculates Area
    /// </summary>
    /// <returns></returns>
    public override float Area(){
        return (edge * edge);
    }

    /// <summary>
    /// Calculates Perimeter
    /// </summary>
    /// <returns></returns>
    public override float Perimeter(){
        return (edge * 4f);
    }

}
}