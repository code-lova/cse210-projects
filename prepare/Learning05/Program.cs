using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Learning05 welcome to Polymorphism!\n");

        Square square = new Square("Green", 2);
        double squareArea = square.GetArea();
        string squareColor = square.GetColor();


        Rectangle rectangle = new Rectangle("Blue", 10, 12);
        double rectangleArea = rectangle.GetArea();
        string rectangleColor = rectangle.GetColor();


        Circle circle = new Circle("Yellow", 24);
        double circleArea = circle.GetArea();
        string circleColor = circle.GetColor();

    

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape s in shapes){

            string colors = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {colors} color shape, has an area of {area}");
            Console.WriteLine();
        }



        // Console.WriteLine($"Area of square is: {squareArea}\nColor of square is: {squareColor}\n");
        // Console.WriteLine($"Area of rectangle is: {rectangleArea}\nColor of rectangle is: {rectangleColor}\n");
        // Console.WriteLine($"Area of circle is: {Math.Round(circleArea, 2)}\nColor of circle is: {circleColor}");


    }
}