using System;
namespace MySecondApplication.Exercises.Six
{
    public class ProcessVideoActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Change the status of the video record in the database to 'Processing'");
        }
    }
}

