/*
 * recordd where introduced in c#9 and aims to help with the equality problem, especially for simple situations
 * where we have "data transfer objects" or "DTOs"
 * a record is a reference type, but it has value semantics
*/

public record MyRecord(int NumericValue,string StringValue);

/*
 * notice how we doin't need to define the properies?! They are automatically created for us. We could do it manually through if we wanted
*/
public record MyRecord2
{
 public int NumericValue { get; init; }
 public string StringValue { get; init; }
}

/*
 *Note that the init keyword is used to make the properties immutable. We can still use the object initializer syntax to create the record through:
 * Tip": An immutable value is one whose content cannot be changed without creating an entirely new value
 */

internal class Program
{
 public static void Main(string[] args)
 {
  MyRecord myRecord1 = new(123, "abc");
  MyRecord2 myRecord2 = new()
  {
   NumericValue = 123,
   StringValue = "abc"
  };

  //but note that in both cases, we cannot change the properties because they are both "init" only:
  // myRecord1.NumericValue = 456; //Does not compile
  // myRecord2.NumericValue = 456;//Does not cmopile

  //How does equailtiy work?
  MyRecord recordA = new(123, "abc");
  MyRecord recordB = new(123, "abc");
  Console.WriteLine("recordA equal to recordB!");
  Console.WriteLine(recordA == recordB); //true
  Console.WriteLine(recordA.Equals(recordB)); //true
  Console.WriteLine(object.Equals(recordA, recordB)); //true
  /*
   * we can also use the 'with' keyword to create a new record with the same value as the original, but with some changes!
   */
  MyRecord recordC = recordA with { NumericValue = 456 };
  //Lets print this to the console and see what these look like:
  Console.WriteLine(recordA); //MyRecord { NumericValue = 123, StringValue = abc }
  Console.WriteLine(recordB); //MyRecord { NumericValue = 123, StringValue = abc }
  Console.WriteLine(recordC); //MyRecord { NumericValue = 456, StringValue = abc }

  //we can deconstruct the record into int's properties!
  var (numericValue, stringValue) = recordA;
 }
 // Notice that tit's positional based on the order of hte properties so this won't work:
   // (string stringValue2, int numericValue2) = recordA; //does not compile

   /*
    * records can also be defined as structs, which means they'll go on the stack instead of the heap. This can be useful
    * for performance reaons, especially if we have a lot of them
    */

   public record struct MyRecordStruct(int NumericValue, string StringValue);

   //If needed, we can mix in the things like additinoal properites that aren't just from the positional ones on the constructor

   public record MyRecordWIthExtreProperties(int NumericValue, string StringValue)
   {
    public string ExtraProperty { get; set; }
   }

   private MyRecordWIthExtreProperties _recordWIthExtreProperties = new MyRecordWIthExtreProperties(123, "abc")
   {
    ExtraProperty = "DEG"
   };

}
