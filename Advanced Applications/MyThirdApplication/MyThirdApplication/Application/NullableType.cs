using System;
namespace MyThirdApplication.Application
{
    public class NullableType
    {
        static void Main(string[] args)
        {
            // Question mark allow DateTime to be nullable
            DateTime? date = null;

            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            Console.WriteLine("Has a Value?: " + date.HasValue);

            // Other examples
            DateTime date2;

            if (date != null)
            {
                date2 = date.GetValueOrDefault();
            }
            else
            {
                date2 = DateTime.Today;
            }

            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            Console.WriteLine("Dates");
            Console.WriteLine("Date " + date);
            Console.WriteLine("Date2 " + date2);
            Console.WriteLine("Date3 " + date3);




        }
    }
}

