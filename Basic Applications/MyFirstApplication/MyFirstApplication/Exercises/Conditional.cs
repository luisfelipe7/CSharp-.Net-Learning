using System;
namespace MyFirstApplication.Exercises
{
  public class Conditional
  {
    static void Main(string[] args)
    {
      // #1
      string message = "Please provide a number between 1 and 10:";
      Console.WriteLine(message);
      int customerNumber = Int32.Parse(Console.ReadLine());
      if (customerNumber > 0 && customerNumber < 11) {
        Console.WriteLine("The number is valid");
      } else {
        Console.WriteLine("The number is invalid");
      }

      // #2
      message = "Please provide two numbers:";
      Console.WriteLine(message);
      int customerNumber1 = Int32.Parse(Console.ReadLine());
      int customerNumber2 = Int32.Parse(Console.ReadLine());
      Console.WriteLine("The max number between the two entered is :" + Math.Max(customerNumber1, customerNumber2));

      // #3
      message = "Please enter the width and height of your favorite image:";
      Console.WriteLine(message);
      double width = Double.Parse(Console.ReadLine());
      double height = Double.Parse(Console.ReadLine());
      if (height > width) {
        Console.WriteLine("The image is portrait");
      } else {
        Console.WriteLine("The image is landscape");
      }

      // #4
      message = "Please enter the speed limit:";
      Console.WriteLine(message);
      double speedLimit = Double.Parse(Console.ReadLine());
      message = "Please enter the speed:";
      Console.WriteLine(message);
      double speed = Double.Parse(Console.ReadLine());
      if (speed <= speedLimit) {
        Console.WriteLine("Ok");
      } else {
        double quantityOfPoints = (speed - speedLimit) / 5;
        if (quantityOfPoints > 12) {
          Console.WriteLine("Your license is suspended");
        } else {
          Console.WriteLine(quantityOfPoints + " points are going to be incurred from your license");
        }

      }


    }
  }
}
