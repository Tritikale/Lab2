using System;
namespace Lab1.ConsoleApp
{
public abstract class Figure{
    protected float edge;

    /// <summary>
    /// Sets edge
    /// </summary>
    /// <param name="a"></param>
    public void Set(float a){
        edge = a;
    }
    public abstract float Perimeter();
    public abstract float Area();


}
}