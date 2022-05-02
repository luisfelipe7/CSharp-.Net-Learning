using System;
namespace MyThirdApplication.Application
{
    public class Dynamic
    {
        static void Main(string[] args)
        {
            int a = 10;

            // In runtime everything is defined for the variable b
            dynamic b = "I am a text";
            b = a;

        }
    }
}
