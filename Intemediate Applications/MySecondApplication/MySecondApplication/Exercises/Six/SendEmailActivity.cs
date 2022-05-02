using System;
namespace MySecondApplication.Exercises.Six
{
    public class SendEmailActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Send an email to the owner of the video notifying them that the video started processing");
        }
    }
}

