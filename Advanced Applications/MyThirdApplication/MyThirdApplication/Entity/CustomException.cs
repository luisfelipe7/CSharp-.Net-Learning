using System;
namespace MyThirdApplication.Entity
{
    public class CustomException : Exception
    {
        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
            // This is the constructor of my Custom Exception

        }
    }
}

