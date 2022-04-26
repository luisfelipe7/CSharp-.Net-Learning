using System;
using System.Runtime.CompilerServices;

namespace MyFirstApplication.Exercises
{
  public class Loop
  {

    static double calculateFactorial(double number)
    {
      if (number == 1) {
        return number;
      } else {
        return number * calculateFactorial(number - 1);
      }

    }


    static void Main(string[] args)
    {
      // #1
      int counterDivisibleBy3 = 0;
      for (int i = 1; i <= 100; i++) {
        if (i % 3 == 0) {
          counterDivisibleBy3 += 1;
        }
      }
      Console.WriteLine("The quantity of numbers divisible by 3 is " + counterDivisibleBy3);



      // #2
      bool enterNumbers = true;
      double sumOfNumbers = 0;
      while (enterNumbers) {
        Console.WriteLine("Please enter a number or type ok to exit");
        var result = Console.ReadLine();
        if (result.ToLower() == "ok") {
          enterNumbers = false;
        } else {
          sumOfNumbers += Double.Parse(result);
        }
      }
      Console.WriteLine("The sum of the entered numbers is " + sumOfNumbers);



      // #3
      Console.WriteLine("Please enter the number that you want to calculate the factorial: ");
      double numberToCalculate = Double.Parse(Console.ReadLine());
      Console.WriteLine("The factorial of " + numberToCalculate + " is : " + Loop.calculateFactorial(numberToCalculate));



      // #4
      Random random = new Random();
      int randomNumber = random.Next(1, 10);
      int chancesToGetNumber = 4;
      int userNumber = 0;
      while (chancesToGetNumber > 0) {
        Console.WriteLine("Please enter the number you think was generated randomly");
        Console.WriteLine("You have " + chancesToGetNumber + " chances to get the number");
        userNumber = Int32.Parse(Console.ReadLine());
        if (userNumber == randomNumber) {
          Console.WriteLine("You guessed the number correctly");
          break;
        } else {
          chancesToGetNumber--;
        }

      }
      if (chancesToGetNumber == 0) {
        Console.WriteLine("You lost, the number was " + randomNumber);
      }




      // #5
      Console.WriteLine("Please enter a series of numbers separated by a comma:");
      string numbers = Console.ReadLine();
      double[] arrayNumbers = Array.ConvertAll(numbers.Split(','), double.Parse);
      double total = 0;
      double max = arrayNumbers[0];
      foreach (var number in arrayNumbers) {
        total += number;
        max = Math.Max(max, number);
      }
      Console.WriteLine("The sum of the numbers entered is: " + total);
      Console.WriteLine("And the max number in the list is: " + max);





    }
  }
}
