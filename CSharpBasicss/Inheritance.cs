using System;
 
public interface IShapeWithSides
{
    public double GetDiagonal();
}
public abstract class Shape
{
    public abstract double GetArea();
 
    public abstract double GetCircumference();
 
    public virtual void Display()
    {
        Console.WriteLine($"Displaying result for some shape");
    }
 
}
 
public class Square : Rectangle
{
    public Square(double side) : base(side, side)
    {
 
    }
 
}
public class Rectangle : Shape, IShapeWithSides
{
    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }
    public double Length { get; set; }
    public double Breadth { get; set; }
 
    public override double GetArea() => Length * Breadth;
 
    public override double GetCircumference() => 2*(Length + Breadth);
     public override void Display()
    {
        Console.WriteLine($"Displaying result for rextangle[{Length}X{Breadth}]:");
        Console.WriteLine($"Area: {this.GetArea()} square unit:\n\t");
        Console.WriteLine($"Area: {this.GetCircumference()} square unit:\n\t");
    }
 
    public double GetDiagonal() => Math.Sqrt(Length * Breadth);
 
}
 
public class Circle : Shape
{
      public Circle(double radious)
    {
      Radious = radious;
    }
    public double Radious { get; set; }
 
    public override double GetArea() => Math.PI * Radious * Radious;
 
    public override double GetCircumference() => 2* Math.PI * Radious;
}
 
// class A 
// {
 
// }
 
// class B : A
// {
    
// }
 
// class C: B
// {
 
// }
 
// class D : A, IA,IB
// {
    
// }
 
// interface IA
// {
 
// }
 
// interface IB 
// {
 
// }

 