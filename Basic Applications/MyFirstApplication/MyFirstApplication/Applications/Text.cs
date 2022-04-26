using System;
using System.Collections.Generic;

namespace MyFirstApplication.Applications

{
  public class Text
  {
    static void Main(string[] args)
    {
      string word = "Felipe Castro";
      Console.WriteLine("Removing whitespace: " + word.Trim());
      Console.WriteLine("To Upper: " + word.ToUpper());

      var index = word.IndexOf(' ');
      var firstName = word.Substring(0, index);
      var lastName = word.Substring(index + 1);
      Console.WriteLine("First Name " + firstName);
      Console.WriteLine("Last Name " + lastName);

      var names = word.Split(' ');
      Console.WriteLine("First Name " + names[0]);
      Console.WriteLine("Second Name " + names[1]);

      Console.WriteLine(word.Replace("Castro", "Sanchez"));
      Console.WriteLine(word.Replace("o", "e"));

      Console.WriteLine("New word: " + word);

      if (String.IsNullOrEmpty(null)) {
        Console.WriteLine("Invalid");
      }

      // Using Convert
      var myString = Convert.ToString(4);
      Console.WriteLine("My String " + myString);

      // Summarizing text
      var sentence = "This is going to be a really really really really really really long text";
      const int maxLength = 20;
      var summaryWords = new List<string>();

      if (sentence.Length < 20) {
        Console.WriteLine(sentence);
      } else {
        var words = sentence.Split(' ');
        var totalCharacters = 0;
        foreach (var word1 in words) {
          summaryWords.Add(word1);

          totalCharacters += word1.Length + 1;
          if (totalCharacters > maxLength)
            break;

        }

        var summary = String.Join(" ", summaryWords) + "....";
        Console.WriteLine("Summary: " + summary);

      }


    }



  }
}
