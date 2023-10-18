using System;


class program
{
    static void Main()
    {
        var circle1 = new Circle(5);
        var circle2 = new Circle(6);

        Console.WriteLine($"Arean på den första cirkeln med radie 5 är: {circle1.GetArea()}");
        Console.WriteLine($"Arean på den andra cirkeln med radie 6 är: {circle2.GetArea()}");
    }
}
