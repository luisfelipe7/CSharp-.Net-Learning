using System;
using AmazonLibrary;

namespace MySecondApplication.Applications
{
  public class AccessModify
  {
    static void Main(string[] args)
    {
      try {
        var consumer = new Consumer();
        AmazonLibrary.RateCalculator calculator = new RateCalculator();

      } catch (Exception e) {
        Console.WriteLine("An unexpected error occurred, message " + e.Message);
      }
    }
  }
}
