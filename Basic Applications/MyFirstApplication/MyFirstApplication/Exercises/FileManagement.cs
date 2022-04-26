using System;

using System.IO;

namespace MyFirstApplication.Exercises
{
  public class FileManagement
  {

    public static void readTextFile(string pathFile)
    {
      var content = File.ReadAllText(pathFile);
      var words = content.Split(" ");

      foreach (var word in words) {
        Console.WriteLine("Word: " + word);

      }

      Console.WriteLine("The quantity of words is: " + words.Length);
    }



    static void Main(string[] args)
    {

      // #1
      string pathFile = @"/Users/felipecastro/Desktop/Felipe Castro/test.txt";
      readTextFile(pathFile);


    }
  }
}
