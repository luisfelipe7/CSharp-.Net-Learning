using System;
namespace MyThirdApplication.Entity
{
    public class Video
    {
        public string Title { get; set; }

        public Video()
        {
            Console.WriteLine("Initializing the Video");
        }
    }
}

