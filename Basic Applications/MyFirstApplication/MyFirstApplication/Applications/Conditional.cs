using System;
using MyFirstApplication.Enums;

namespace MyFirstApplication.Applications
{
  public class Conditional
  {
    static void Main(string[] args)
    {
      int hour = 10;
      if ((hour > 0) && (hour < 12)) {
        Console.WriteLine("It's morning");
      } else if ((hour >= 12) && (hour < 18)) {
        Console.WriteLine("It's afternoon");
      } else {
        Console.WriteLine("It's evening");
      }

      bool isGoldCustomer = true;
      float price;
      if (isGoldCustomer) {
        price = 19.95f;
      } else {
        price = 29.95f;
      }
      Console.WriteLine("The price for you is " + price);

      bool isDead = true;
      string message = (isDead) ? message = "You are dead" : message = "You are not dead";
      Console.WriteLine("Message is: " + message);

      switch ((int)Province.Heredia) {
        case (4):
          Console.WriteLine("You were born in Heredia");
          break;
        default:
          Console.WriteLine("You were not born in Heredia");
          break;
      }

    }
  }
}
