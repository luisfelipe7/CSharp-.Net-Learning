using System;
namespace MyThirdApplication.Application
{
    public class PhotoProcessor
    {
        // OLD Way
        //public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            // Here the filters assigned to the deletage will be applied
            filterHandler(photo);

            photo.Save();
        }

        public PhotoProcessor()
        {
        }
    }
}

