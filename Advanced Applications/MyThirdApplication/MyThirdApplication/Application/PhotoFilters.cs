using System;
namespace MyThirdApplication.Application
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }

        // Here or in any other class we can add filters using the same pattern "void MethodNmae(Photo param)"
        public void RemoveRedEyes(Photo photo)
        {
            Console.WriteLine("Red eyes removed from the photo");
        }

    }
}

