using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstApplication.Exercises
{
  public class ArrayList
  {
    static void Main(string[] args)
    {

      // #1
      bool askForNames = true;
      var namesList = new List<String>();

      while (askForNames) {
        Console.WriteLine("Please enter a name (try to enter different names) \n Or enter exit to stop introducing names");
        string name = Console.ReadLine();
        if (name.ToLower() != "exit") {
          namesList.Add(name);
        } else {
          break;
        }
      }

      switch (namesList.Count) {
        case 0:
          Console.WriteLine("No one likes your post");
          break;
        case 1:
          Console.WriteLine(namesList.ElementAt(0) + " likes your post");
          break;
        case 2:
          Console.WriteLine(namesList.ElementAt(0) + " and " + namesList.ElementAt(1) + " like your post");
          break;
        default:
          int numberOfOtherPeople = namesList.Count - 2;
          Console.WriteLine(namesList.ElementAt(0) + ", " + namesList.ElementAt(1) + " and " + numberOfOtherPeople + " others like your post");
          break;
      }


      // #2
      Console.WriteLine("Please tell me your name:");
      string name2 = Console.ReadLine();
      char[] lettersOfName = name2.ToCharArray();
      Array.Reverse(lettersOfName);
      Console.WriteLine("Your name reversed is : " + new string(lettersOfName));



      // #3
      int counterOfNumbers = 0;
      int[] arrayOfNumbers = new int[5];
      while (counterOfNumbers < 5) {
        Console.WriteLine("Please enter a number and try don't repeat it: ");
        int numberEntered = Int32.Parse(Console.ReadLine());
        bool isInTheArray = arrayOfNumbers.Contains(numberEntered);

        if (isInTheArray) {
          Console.WriteLine("The number is already in the array");
        } else {
          arrayOfNumbers[counterOfNumbers] = numberEntered;
          counterOfNumbers++;
        }
      }
      Array.Sort(arrayOfNumbers);
      Console.WriteLine("Here are the 5 unique numbers ordered that you entered");
      foreach (var number in arrayOfNumbers) {
        Console.WriteLine(number);
      }



      // #4
      bool askForNumbers = true;
      var numbersList = new List<int>();

      while (askForNumbers) {
        Console.WriteLine("Please enter a number \n Or enter Quit to stop introducing numbers");
        var element = Console.ReadLine();

        if (element.ToLower() != "quit") {
          numbersList.Add(Int32.Parse(element));
        } else {
          break;
        }
      }
      var numbersUniqueList = numbersList.Distinct();
      Console.WriteLine("The list of unique numbers entered is:");
      foreach (var number in numbersUniqueList) {
        Console.WriteLine("Unique-number: " + number);
      }



      // #5
      bool isListGood = true;
      string listOfNumbers;
      int[] numbersArray2;

      do {
        Console.WriteLine("Please enter a list of numbers separated by comma /n (the list must include at least 5 numbers)");
        listOfNumbers = Console.ReadLine();
        numbersArray2 = Array.ConvertAll(listOfNumbers.Split(','), int.Parse);

        if ((numbersArray2.Count() == 0) || (numbersArray2.Count() < 5)) {
          isListGood = false;
        } else {
          break;
        }

      } while (!isListGood);

      Array.Sort(numbersArray2);
      Console.WriteLine("The three smallest numbers are: ");
      Console.WriteLine(numbersArray2[0]);
      Console.WriteLine(numbersArray2[1]);
      Console.WriteLine(numbersArray2[2]);






    }
  }
}
