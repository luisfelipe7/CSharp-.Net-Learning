using System;

namespace MyFirstApplication
{
  public class DataType
  {
    static void Main(string[] args)
    {
      // Primitive Data Types

      // Every number by default is taken by C# as double
      byte number = 7;
      int age = 24;
      float totalDolars = 20.95f; // We have to indicate here it is a float

      // Words
      string name = "Felipe";
      char myInitial = 'F';

      // Bool
      bool isWorking = true;

      // Letting C# decide the type with var
      var number2 = 24;
      var mySecondInitial = 'L';

      // Printing the Data Types 
      Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old");
      Console.WriteLine("My favorite number is " + number + ", my initial is " + myInitial + " and my dolares are " + totalDolars);
      Console.WriteLine("I am working? Answer : " + isWorking);
      Console.WriteLine("My second favorite number is " + number2 + " and my second initial is " + mySecondInitial);

      // We can do F12 to get information about any object

      // Using a Format String
      Console.WriteLine("Min Byte: {0} Max Byte: {1}", byte.MinValue, byte.MaxValue);

      // Const
      const float pi = 3.14f;
      // pi = 3.14f; -> This will cause an error because the variable is const
      Console.WriteLine("The value of pi is: " + pi);

      // DateTime
      var dateTime = new DateTime(2015, 1, 1);
      var now = DateTime.Now;
      var today = DateTime.Today;

      Console.WriteLine("Hour : " + now.Hour);
      Console.WriteLine("Minute : " + now.Minute);

      var tomorrow = now.AddDays(1);
      var yesterday = now.AddDays(-1);

      Console.WriteLine(now.ToLongDateString());
      Console.WriteLine(now.ToShortDateString());
      Console.WriteLine(now.ToLongTimeString());
      Console.WriteLine(now.ToShortTimeString());
      Console.WriteLine(now.ToString("yyyy-MM-dddd"));

      // TimeSpan
      var timeSpan = new TimeSpan(1, 2, 3);
      var timeSpan1 = new TimeSpan(1, 0, 0);
      var timeSpan2 = TimeSpan.FromHours(1);
      var start = DateTime.Now;
      var end = DateTime.Now.AddMinutes(2);
      var duration = end - start;
      Console.WriteLine("Duration: " + duration);
      // TimeSpan properties
      Console.WriteLine("Minutes : " + timeSpan.Minutes);
      Console.WriteLine("Total Minutes : " + timeSpan.TotalMinutes);
      // Add
      Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
      Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

      Console.WriteLine("ToString " + timeSpan.ToString());



    }
  }
}
