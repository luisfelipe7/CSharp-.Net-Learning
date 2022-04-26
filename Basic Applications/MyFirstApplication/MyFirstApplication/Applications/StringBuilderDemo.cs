using System;
using System.Text;

namespace MyFirstApplication.Applications
{
  public class StringBuilderDemo
  {
    static void Main(string[] args)
    {
      // Using StringBuilder
      var builder = new StringBuilder("My Initial String");
      // Methods
      builder.Append('-', 10)
      .AppendLine()
      .Append("Header")
      .AppendLine()
      .Append('-', 10)
      .Replace('-', '+')
      .Remove(0, 10)
      .Insert(0, new String('-', 10));

      Console.WriteLine(builder);


      var myString = "Hello World! ";
      Console.WriteLine("My String: " + myString);
      myString = "Hello";
      Console.WriteLine("My String again: " + myString);


    }
  }
}
