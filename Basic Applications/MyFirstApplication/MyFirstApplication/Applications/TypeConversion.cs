using System;
namespace MyFirstApplication
{
  public class TypeConversion
  {
    static void Main(string[] args)
    {
      // Converting without having data loss
      byte b = 1;
      int i = b;
      Console.WriteLine("i value " + i + " b value " + b);

      // Viceversa we can't do it
      int i2 = 1;
      // byte b2 = i2; -> This will cause an error
      byte b2 = (byte)i2; // Here I need to indicate that I agree to have data loss

      // I can't do this, because they are not compatible
      var number = 1234;
      // string word = number; -> This is an error
      string word = Convert.ToString(number); // We can do this
      Console.WriteLine("Word: " + word + " Number:" + number);

      // In this case this will overflow the byte because it does not have enough storage to save the word
      // Using try to catch the exception
      try {
        var word2 = "1234";
        byte b3 = Convert.ToByte(word2);
        Console.WriteLine("This is the value of b3: " + b3);
      } catch (OverflowException exception) {
        Console.WriteLine("The word can't no be converted to type");
        Console.WriteLine("Error message: " + exception.Message);

      } catch (Exception exception) {
        Console.WriteLine("Catching any exception");
        Console.WriteLine("Error: " + exception.Message);



      }

    }
  }
}