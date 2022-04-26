using System;
namespace MyFirstApplication.Applications
{
  public class Loop
  {
    static void Main(string[] args)
    {
      // Using for
      for (var i = 1; i <= 10; i++) {
        if (i % 2 == 0) {
          Console.WriteLine(i + " is even");
        }

      }
      // Using foreach
      var fullName = "Luis Felipe Castro Sanchez";
      foreach (var letter in fullName) {
        if (letter != ' ') {
          Console.WriteLine("Letter: " + letter);
        }
      }

      // Using while loop
      var foundNumberDivisibleBy8 = false;
      var number = 1;
      while (!foundNumberDivisibleBy8) {
        if ((number % 8 == 0) && (number != 8)) {
          foundNumberDivisibleBy8 = true;
          break;
        }
        number++;
      }
      Console.WriteLine("The divisible number by 8 found is " + (number));

      // Using random
      var random = new Random();
      for (int i = 0; i < 10; i++) {
        Console.WriteLine(random.Next());
      }
      // Run random until 8 is generated randomly
      number = 0;
      while (number != 8) {
        number = random.Next(1, 10);
        Console.WriteLine("Number " + number);
      }

      // Generate random letters
      var passwordMaxSize = 10;
      var letters = new char[passwordMaxSize];
      for (int i = 0; i < 10; i++) {
        letters[i] = (char)('a' + random.Next(0, 26));
        Console.Write(letters[i]);
      }
      var password = new String(letters);
      Console.WriteLine("Password " + password);

    }
  }

}
