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
    public override float HalfArea(){
        return (this.Area() / 2);
    }
    public override float HalfPerimeter(){
        return(this.Perimeter() / 2);
    }
    public override bool IsEqual(Figure x){
        return(x.Get() == edge);
    }
    public override bool IsBigger(Figure param){
        return (param.Get() > edge);
    }
    public override bool IsSmaller(Figure param){
        return (param.Get() < edge);
    }
}
}