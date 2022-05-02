using System;
using MyThirdApplication.Entity;

namespace MyThirdApplication.Application
{
    public class HandlingException
    {
        static void Main(string[] args)
        {
            // Using Exceptions
            try
            {

                try
                {
                    // Generating a divided by zero exception
                    var number = 1;
                    var result = number / 0;

                }
                // Internal Catch
                catch (Exception exception)
                {
                    Console.WriteLine("Exception catched: " + exception.Message);
                    Console.WriteLine("Throwing a custom exception");
                    throw new CustomException("I am the message of the custom exception", exception);

                }

            }
            // General Catch
            catch (CustomException customException)
            {
                Console.WriteLine("Custom exception catched: " + customException.Message);
            }
            // This is always executed
            finally
            {
                Console.WriteLine("I'm always executed with or without an exception");
            }



        }
    }
}

