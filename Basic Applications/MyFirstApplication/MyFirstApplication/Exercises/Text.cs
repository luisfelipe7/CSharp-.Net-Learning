using System;
using System.Linq;

namespace MyFirstApplication.Exercises
{
  public class Text
  {
    // #1

    static void checkConsecutive(string numbers)
    {
      var numbersToCheck = numbers.Split("-");
      var allGood = true;
      double previousNumber = 0;
      for (int i = 0; i < numbersToCheck.Length; i++) {
        if (i == 0) {
          previousNumber = Convert.ToDouble(numbersToCheck[0]);
        } else {
          if (previousNumber + 1 != Convert.ToDouble(numbersToCheck[i])) {
            allGood = false;
            break;
          } else {
            previousNumber = Convert.ToDouble(numbersToCheck[i]);
          }
        }
      }

      if (allGood) {
        Console.WriteLine("Consecutive");
      } else {
        Console.WriteLine("Not Consecutive");
      }


    }


    // #2
    static void checkDuplicateOrEmpty(string numbers)
    {
      if (String.IsNullOrEmpty(numbers) || String.IsNullOrWhiteSpace(numbers)) {
        Console.WriteLine("Do Nothing");
      } else {
        var numbersArray = numbers.Split("-");
        var distinctArray = numbersArray.Distinct();

        if (numbersArray.Length == distinctArray.Count()) {
          Console.WriteLine("Not Duplicate");
        } else {
          Console.WriteLine("Duplicate");
        }

      }

    }



    // #3
    static void checkTime(string userHour)
    {
      string[] hoursMinutes = userHour.Split(":");
      double hours = Convert.ToDouble(hoursMinutes[0]);
      double minutes = Convert.ToDouble(hoursMinutes[1]);

      if (hours > 23 || hours < 0) {
        Console.WriteLine("Invalid Time");
      } else {
        if (minutes > 59 || minutes < 0) {
          Console.WriteLine("Invalid Time");
        } else {
          Console.WriteLine("Valid Time");
        }
      }



    }

    // #4
    static void creatingPascalCase(string wordsUser)
    {
      string[] words = wordsUser.Split(" ");
      string myPascalCaseString = "";
      foreach (var word in words) {
        char[] letters = word.ToLower().ToArray();
        letters[0] = Char.ToUpper((letters[0]));
        string newWord = new string(letters);
        myPascalCaseString += newWord;
      }

      Console.WriteLine("The word in Pascal Case is " + myPascalCaseString);

    }


    // #5
    static void vocalsCounter(string wordUser)
    {
      int vocalsQuantity = 0;
      foreach (var letter in wordUser) {
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u') {
          vocalsQuantity += 1;
        }
      }

      Console.WriteLine("The quantity of letters in the word you entered is: " + vocalsQuantity);
    }


    static void Main(string[] args)
    {

      // #1
      Console.WriteLine("Please enter numbers separated by - and then press enter");
      string numbers = Console.ReadLine();
      Text.checkConsecutive(numbers);

      // #2
      Console.WriteLine("Please enter numbers separated by - and then press enter");
      numbers = Console.ReadLine();
      Text.checkDuplicateOrEmpty(numbers);

      // #3
      Console.WriteLine("Please enter the time with this format 00:00");
      numbers = Console.ReadLine();
      Text.checkTime(numbers);

      // #4
      Console.WriteLine("Please enter some words separated by space");
      numbers = Console.ReadLine();
      creatingPascalCase(numbers);

      // #5
      Console.WriteLine("Please enter a single word");
      numbers = Console.ReadLine();
      vocalsCounter(numbers);

    }
  }
}
