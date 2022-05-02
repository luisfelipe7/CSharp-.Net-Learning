using System;
namespace MyThirdApplication.Application
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            Console.WriteLine("Loading the Photo in the path " + path);
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("Saving the Photo");
        }

    }
}

