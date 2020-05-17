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
    public float Get(){
        return(edge);
    }
    public abstract float Perimeter();
    public abstract float Area();
    public abstract float HalfArea();
    public abstract float HalfPerimeter();
    public abstract bool IsEqual(Figure param);


}
}