/* abstract classes in C# are the classes that
 - cannot be instantiated
 - can define some base/shared functionality
 - can have abstract methods

The Core difference between absract classes and interfaces is that we can actually define methods within the abstract class that derived classes can actually use. Interfaces are simply just the API and therefore can not
have pre- defined method behaviour.
*/


class MyDerivedClass : MyBaseClass
{
    // Main Method
    public static void Main(String[] args)
    {

        Console.WriteLine("Main Method");
    }
    //we *MUST* implement the abstract mehtod when we derive from an abstract class!
    public override void PrintAbstract()
    {
        Console.WriteLine("PrintAbstract() in MyDerivedClass");
    }
}

abstract class MyBaseClass
{
    public void Print()
    {
        Console.WriteLine("Print() in MyBaseClass");
    }

    public abstract void PrintAbstract();
}
/*
 * Note that we cannot instantiate an abstract class!
 * MyBaseClass myBaseClass = new MyBaseClass(); - Does not compile
 *
 *  instead, we can create a derived class from it.
 */