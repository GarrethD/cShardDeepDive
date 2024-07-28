/*
 * What if we don't want our base class to have methods that EVERYONE can use?
 * What if we want to limit ti?
 * Protected!!!!!
 */

abstract class AbstractBaseClass
{
    
    protected void ProtectedPrintInbaseClass()
    {
        Console.WriteLine("ProtectedPrintInbaseClass");
    }

    protected abstract void ProtectedAbstractPrint();
}

class DerivedClass : AbstractBaseClass
{
        // Main Method
    public static void Main(String[] args)
    {

        Console.WriteLine("Main Method");
    }
    public void PrintInSDerivedClass()
    {
        Console.WriteLine("We're in the derived class!");
        ProtectedPrintInbaseClass();
        Console.WriteLine("We're leaving the method in the derived class!");
    }
    
    protected override void ProtectedAbstractPrint()
    {
        Console.WriteLine("ProtectedAbstractPrint");
    }
}

/*
 * We can also use the virtual keyword to give us a hybrid between abstract and non-abstract 
 */
class BaseClass2
{
    protected void PrintInBaseClass()
    {
        Console.WriteLine("PrintInBaseClass");
    }

    public virtual void VirtualPrintInBaseClass()
    {
        Console.WriteLine("VirtualPrintInBaseClass");
    }
}

class DerivedClass2 : BaseClass2
{
    public void PrintInDerivedClass()
    {
        Console.WriteLine("PrintInDerivedClass... Then Base!");
        PrintInBaseClass();
    }

    public override void VirtualPrintInBaseClass()
    {
      Console.WriteLine("VirtualPrintInBaseClass in the derived class");
      Console.WriteLine("....... and now we'll call the base class method!");
      base.VirtualPrintInBaseClass();
    }
}
