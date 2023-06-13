using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shape = new List<Shape>();

        Square shape1 = new Square("Red", 4);
        shape.Add(shape1);

        Circle shape2 = new Circle("Blue", 5);
        shape.Add(shape2);
        
        Rectangle shape3 = new Rectangle("Purple", 17);
        shape.Add(shape3);
    
    foreach (Shape shap in shape)
    {    
        string color = shap.GetColor();

        double side = shap.GetArea();
       
        Console.WriteLine($"The Shape that is {color} has an area of {side}.");       
    }
    }
}