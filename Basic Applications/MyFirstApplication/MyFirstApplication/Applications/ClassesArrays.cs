using System;
using MyFirstApplication.Enums;

namespace MyFirstApplication
{
  public class ClassesArrays
  {
    static void Main(string[] args)
    {
      // Using the Person Class
      var person = new Person();
      person.name = "Felipe";
      person.age = 24;
      person.Introduce();

      // Using the Calculator Class
      Calculator calculator = new Calculator();
      var result = calculator.Add(4, 6);
      Console.WriteLine("The value of result is : " + result);

      // Using Arrays
      var numbers = new int[5];
      numbers[0] = 1;

      // By default all the elements are initialized to the value default of the type
      Console.WriteLine(numbers[0]);
      Console.WriteLine(numbers[1]);
      Console.WriteLine(numbers[2]);

      var flags = new bool[2];
      flags[0] = true;

      // Printing the array
      foreach (var flag in flags) {
        Console.WriteLine("Value of flag is " + flag);
      }

      // Initializing the array
      var names = new string[3] { "Jack", "Jhon", "Mary" };

      // Printing the array
      for (int i = 0; i < names.Length; i++) {
        Console.WriteLine("Name[" + i + "] is : " + names[i]);
      }

      // Using Types

      var firstName = "Mosh";
      string lastName = "Hamedani";
      // Using .net class
      String message = "Welcome!";
      var fullName = firstName + " " + lastName;

      // Using string methods
      var fullName2 = string.Concat(firstName, lastName);
      var presentationMessage = string.Format("My name is {0} {1} ", firstName, lastName);
      var people = new string[3] { "Luis", "Felipe", "Yenifer" };
      var verboseMessage = @"Line 1
Line 2
Line 3";

      Console.WriteLine(fullName);
      Console.WriteLine(fullName2);
      Console.WriteLine(presentationMessage);
      Console.WriteLine(string.Join("-", people));
      Console.WriteLine("Hello, \n Welcome to my program!");
      Console.WriteLine(verboseMessage);

      // Calling my Enum
      var herediaId = (int)Province.Heredia;
      Console.WriteLine("The Heredia id is " + herediaId);

      // Console.WriteLine by default called the toString of anything
      // So that's why I indicated (int)



    }
  }
}
