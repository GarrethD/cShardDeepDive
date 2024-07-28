// one of the big challenges with value and reference types has to do with checking for equality


//let's look at class equality
var myClass1 = new MyClass {NumericValue = 123, StringValue = "ABC"};
var myClass2 = new MyClass {NumericValue = 123, StringValue = "ABC"};
Console.WriteLine("myClass1 equal to myClass2:");
Console.WriteLine(myClass1 ==myClass2);//false
Console.WriteLine(myClass1.Equals(myClass2));//false
Console.WriteLine(object.Equals(myClass1,myClass2));//false

//Let's look at struct equality
var myStruct1 = new MyStruct {NumericValue = 123, StringValue = "ABC"};
var myStruct2 = new MyStruct {NumericValue = 123, StringValue = "ABC"};
Console.WriteLine("myStruct1 equal to myStruct2:");
// Console.WriteLine(myStruct1 == myStruct2);//Can't do double == with a struct. Does not compile
Console.WriteLine(myStruct1.Equals(myStruct2));//true
Console.WriteLine(object.Equals(myStruct1,myStruct2));//true

public class MyClassWithEquality
{
    public int NumericValue { get; set;}

    public string StringValue { get; set;}

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var other = (MyClassWithEquality)obj;
        return NumericValue == other.NumericValue && StringValue == other.StringValue;
    }

    public override int GetHashCode()
    {
        return NumericValue.GetHashCode() ^ NumericValue.GetHashCode();
    }
}

public class MyClass
{
    public int NumericValue { get; set; }
    public string StringValue { get; set; }
}

public struct MyStruct
{
    public int NumericValue { get; set; }
    public string StringValue { get; set; }
}