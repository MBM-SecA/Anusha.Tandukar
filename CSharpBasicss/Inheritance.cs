using System;

public interface IShapeWithSides

{

    public void GetDiagonal();

 

 

}

public abstract class Shape

{

    //abstract members are made when one wnats to force dervied classes to implement own logic

 

    public abstract double GetArea(); //{return 0.0;}

public abstract double GetCircumference();

public virtual void Display()

{

     Console.WriteLine($"Displaying Result forsome shape");

}

}

public class Square : Shape , IShapeWithSides

{

    public Square(double side)

    {

        Side=side;

    }

     public double Side{get;set;}

    public override double GetArea() =>Side*Side;

   

    public override double GetCircumference() =>Side*4;

    public override void Display ()

    {

        Console.WriteLine($"Displaying results for Square with side{Side}:\n\t");

        Console.WriteLine($"Area:{this.GetArea()} square units");

        Console.WriteLine($"Circumfrence{this.GetCircumference()}:");

    }

    public double GetDiagonal()=>Math.Sqrt(2*(Side*Side));

    void IShapeWithSides.GetDiagonal()
    {
        throw new NotImplementedException();
    }
}

public class Rectangle : Shape

{

    public Rectangle(double length, double breadth)

    {

        Length=length;

        Breadth=breadth;

    }

    public double Length {get;set;}

    public double Breadth {get;set;}

 

    public override double GetArea() =>Length*Breadth;

   

    public override double GetCircumference() =>2*(Length+Breadth);

   

 

}

public class Circle : Shape

{

    public Circle(double radius)

    {

       Radius=radius;

    }

    public double Radius {get;set;}

  

 

    public override double GetArea() =>Math.PI*Radius*Radius;

   

    public override double GetCircumference() =>2*Math.PI*Radius;

 

   

 

}

class A

{

 

}

class B:A{

 

}

class C:B

{

 

}

class D:A, IA,IB

{

 

}

 

interface IA

{

 

}

interface IB

{

 

}

 