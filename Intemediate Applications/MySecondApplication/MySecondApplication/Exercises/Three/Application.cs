using System;
using System.Collections;

namespace MySecondApplication.Exercises.Three
{
  public class Application
  {
    static void displayAnyKeyMessage()
    {
      Console.WriteLine("");
      Console.WriteLine("Press Any Key To Continue....");
      Console.ReadKey();
    }

    static void Main(string[] args)
    {

      StackSystem stackSystem = new StackSystem();
      int option = 0;

      while (option != 5)
      {
        Console.WriteLine("---------------------  StackSystem --------------------------");
        Console.WriteLine("Please enter the number for the option you want to perform:");
        Console.WriteLine("- 1: Push Element");
        Console.WriteLine("- 2: Pop Element");
        Console.WriteLine("- 3: Clear Stack");
        Console.WriteLine("- 4: Display Actual Stack");
        Console.WriteLine("- 5: Exit");
        option = Convert.ToInt32(Console.ReadLine());

        try
        {
          switch (option)
          {
            case 1:
              Console.WriteLine("\n Please enter the element to push ");
              object element = Console.ReadLine();
              stackSystem.Push(element);
              break;
            case 2:
              stackSystem.Pop();
              break;
            case 3:
              stackSystem.Clear();
              break;
            case 4:
              stackSystem.DisplayActualStack();
              break;
          }
        }
        catch (Exception exception)
        {
          Console.WriteLine("\n Unexpected error ocurred, message: " + exception.Message);
        }

        if (option != 5)
        {
          displayAnyKeyMessage();
        }

        Console.Clear();
      }


      Console.WriteLine("Thanks for using our application");



    }
  }
}

