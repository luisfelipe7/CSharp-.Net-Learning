using System;
namespace MySecondApplication.Entity
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
        }

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
        }
    }
}

