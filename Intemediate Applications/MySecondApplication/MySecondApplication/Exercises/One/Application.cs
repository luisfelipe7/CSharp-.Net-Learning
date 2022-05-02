using System;
namespace MySecondApplication.Exercises.One
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
      try {
        StopwatchSystem stopwatchSystem = new StopwatchSystem();
        int option = 0;

        while (option != 4) {
          Console.WriteLine("---------------------  STOPWATCH --------------------------");
          Console.WriteLine("Please enter the number for the option you want to perform:");
          Console.WriteLine("- 1: Start StopWatch");
          Console.WriteLine("- 2: Stop StopWatch");
          Console.WriteLine("- 3: Check Actual Duration");
          Console.WriteLine("- 4: Exit");
          option = Convert.ToInt32(Console.ReadLine());

          switch (option) {
            case 1:
              stopwatchSystem.StartStopWatch();
              displayAnyKeyMessage();
              break;
            case 2:
              stopwatchSystem.StopStopWatch();
              displayAnyKeyMessage();
              break;
            case 3:
              stopwatchSystem.DisplayDuration();
              displayAnyKeyMessage();
              break;
          }

          Console.Clear();
        }


        Console.WriteLine("Thanks for using our application");

      } catch (Exception exception) {
        Console.WriteLine("Exception message: " + exception.Message);
      }
    }
  }
}
