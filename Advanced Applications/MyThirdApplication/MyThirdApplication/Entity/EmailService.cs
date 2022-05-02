using System;
namespace MyThirdApplication.Entity
{
    public class EmailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("EmailService: Sending an email message " + args.Video.Title);
        }
    }
}

