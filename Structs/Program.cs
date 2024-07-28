// a struct is a value type, even though it looks like a class!
// here is an example of a struct


public struct Point
{
    public int X;
    public int Y;
}


//Here is the same struct but with properites
public struct PointWithProperties
{
    public int X { get; set;}
    public int Y { get; set;}
}
//Here is the same struct with a constructor
public struct PointWithConstructor
{
    public PointWithConstructor(int x, int y)
    {
        X = x;
        Y = y;
    }
    public int X { get; set; }
    public int Y { get; set; }
}
// We can have a struct with a method, just like with classes

public struct PointWithMethod
{
    public int X;
    public int Y;

    public void Move(int x, int y)
    {
        X += x;
        Y += y;
    }
}
/*
 * So what is the different between a struct and a class?
 * Why would we make a struct instead of a class?
 *
 * The main difference is that a struct is avalue type, and a calss is a reference type.
 * - A struct is stored on the stack, and a class is stored on the heap
 * - A struct is copied wehn it passes to a method, and a class is passed by reference
 *
 * Objects that are on the heap end up needing to be garbage collected where as objects on the stack do not.q
*/

// here is an example of a struct being copied when passed to a method

internal class Program
{
    public static void Main(string[] args)
    {
        void DoSomethingWIthPoint(Point p)
        {
            p.X = 111;
            p.Y = 222;
        }

        var ourPoint = new Point()
        {
            X = 123,
            Y = 456
        };
        Console.WriteLine($"ourPoint before DoSOmethingWIthPoint: " + $"{ourPoint.X}, {ourPoint.Y}");
        DoSomethingWIthPoint(ourPoint);
        Console.WriteLine($"ourPoint after DoSOmethingWIthPoint: " + $"{ourPoint.X}, {ourPoint.Y}");
    }
}
/*
 * Becuase struct can look like classes , it can be confusing when to use a strcut and when to use a class/ here are some guidlines:
 *
 * - use a struct when you have a small , simple object that you want to pass by value
 * - use a struct when you want to avoid the overhead of heap allocation, garbage collecting, etc
 *
 * Try to think about very primitivate things like a point, or a color, or a rectangle, or other gemoetric things
*/