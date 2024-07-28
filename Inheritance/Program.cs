/*
 * Key observations to note. The 'GetType.Name' returns the class name that has been instantiated. This means that whenever we gettting the type by name, we will return the actual class name 'Calling get Type will return the most specific type'
 * The phrase "instantiating a class" means the same thing as "creating an object." When you create an object, you are creating an "instance" of a class, therefore "instantiating" a class.
 */

Car sedan = new () { DoorCount = 4 };
Car coupe = new () { DoorCount = 2 };
Truck fourByFour = new() { DoorCount = 2 };
Bike bike = new();

sedan.OpenDoors();
coupe.OpenDoors();
fourByFour.OpenDoors();
bike.OpenDoors();

public class Vehicle
{
    public int DoorCount { get; set; }

    public void OpenDoors()
    {
        Console.WriteLine($"{GetType().Name} opening {DoorCount} doors!");
    }
}

public class Automobile : Vehicle
{
}

public class Car : Automobile
{
}

public class Truck : Automobile
{
}

public class Van : Automobile
{
}

public class Bike : Vehicle
{
    public Bike()
    {
        DoorCount = 0;
    }
}

public class Plane : Vehicle
{
}