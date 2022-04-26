using System;
namespace MyFirstApplication
{
  public class Operator
  {
    static void Main(string[] args)
    {
      // Defining the variables
      var number1 = 4;
      var number2 = 6;
      var number3 = 2;

      // Using the operators
      Console.WriteLine("The result is: " + (number1 + number2 * number3));
      // Comparison
      Console.WriteLine("Is " + number1 + " bigger than " + number2 + "? " + (number1 > number2));
      // Using the comparison operators
      Console.WriteLine("The result is: " + (number2 > number3 && number2 > number1));


    }
  }
}
