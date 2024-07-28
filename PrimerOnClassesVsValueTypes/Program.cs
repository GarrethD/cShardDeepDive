//Classes are referrence types in c#
//the primitive type (like int, double,and bools) are value types

/*/
 recall that weh we use a reference type, we are passing 
 around a reference to the object in memory
 */

List<string> ourList = new()
{
 "Hello",
 "World",
};

void DoSomethingWithReference(List<string> list)
{
 list.Add("From");
 list.Add("Garreth");
}
Console.WriteLine("Reference Before:");
foreach (var item in ourList)
{
 Console.WriteLine(item);
}
DoSomethingWithReference(ourList);
Console.WriteLine("Reference After:");
foreach (var item in ourList)
{
Console.WriteLine(item); 
}

//========================= Value type example====================
string ourString = "Hello, World!";

void DoSomethingWithValue(string value)
{
 value = "Goodbye, World";
}
Console.WriteLine("Value Before");
Console.WriteLine(ourString);
DoSomethingWithValue(ourString);
Console.WriteLine("Value After");
Console.WriteLine(ourString);
//========================= Hybrid  example using reference and value type ====================
// we can pass a value type by reference using the ref keyword

void DoSOmethingWithValueByRef(ref string value)
{
 value = "Goodbye, World!";
}
Console.WriteLine("Value Before by ref:");
Console.WriteLine(ourString);
DoSOmethingWithValueByRef(ref ourString);
Console.WriteLine("Value After by ref:");
Console.WriteLine(ourString);


/*
 * Final notes from Me(Garreth)
 * Value types can not be changed as we are simply duplicated ing the value to then do something with it. The original value
 * stays intacted.
 *
 * Reference types modifies the original value. Using re ref keyword allows us to make changes to the actual reference(original value)
*/

