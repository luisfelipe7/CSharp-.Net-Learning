using System;
using System.Collections.Generic;
using MyThirdApplication.Application;
using MyThirdApplication.Entity;

namespace MyThirdApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++ Reviewing Advanced Topics ++++++++++++++++ ");

            // Example of Indexers
            MyCalculator myCalculator = new MyCalculator();
            myCalculator[0] = 2;
            Console.WriteLine("\n ----- Indexers example -----");
            Console.WriteLine("The value located in the array numbers inside myCalculator at the position 0 is: " + myCalculator[0]);

            // Example of Delegates
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            // Creating the delegate and setting the method
            Action<Photo> filterHandler = filters.ApplyBrightness;
            // Adding methods
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.RemoveRedEyes;
            Console.WriteLine("\n ----- Delegates example -----");
            processor.Process("photo.jpg", filterHandler);

            // Lambdas
            Console.WriteLine("\n ----- Lambdas -----");
            // args => expresion
            // () => ...
            // x => ...
            // (x,y,z) => ...
            Func<int, int> square = argument => argument * argument;
            Console.WriteLine("The square of 5 is " + square(5));
            const int valueToMultiply = 5;
            Func<int, int> multiplier = argument => argument * valueToMultiply;
            var result = multiplier(10);
            Console.WriteLine("The result of doing 10*5 is " + result);
            Book book1 = new Book("Moby Dick", 9, 1);
            Book book2 = new Book("Dracula", 15, 0);
            Book book3 = new Book("Harry Potter 1", 50, 1);
            Book book4 = new Book("Spiderman 1", 25, 10);

            BookStore bookStore = new BookStore();
            bookStore.AddBook(book1);
            bookStore.AddBook(book2);
            bookStore.AddBook(book3);
            bookStore.AddBook(book4);
            bookStore.DisplayCheapBooks();

            // Using LINQ
            Console.WriteLine("\n ----- LINQ -----");
            bookStore.DisplayAvailableTitles();
            bookStore.DisplayBooksHavingTitleWithOne();
            Console.WriteLine("The most expensive book is: " + bookStore.GetTheMostExpensiveBook());
            Console.WriteLine("The first available book is: ");
            bookStore.DisplayFirstBookAvailable();
            Console.WriteLine("The total of books available is: " + bookStore.GetTotalBooksAvailable());


            // Events
            Console.WriteLine("\n ----- Events -----");
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // Publisher of the event
            var messageService = new MessageService(); // Subscriber
            var emailService = new EmailService(); // Subscriber
            // Subscribing
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.VideoEncoded += emailService.OnVideoEncoded;
            videoEncoder.Encode(video);


            // Extension Method
            Console.WriteLine("\n ----- Extension Methods -----");
            string myString = "luis";
            string myString2 = "luis felipe";
            string myString3 = "luis felipe castro";
            List<string> myStrings = new List<string>();
            myStrings.Add(myString);
            myStrings.Add(myString2);
            myStrings.Add(myString3);
            foreach (var element in myStrings)
            {
                // Using the extended method created
                Console.WriteLine(element.ConvertToPascalCase());
            }



        }
    }
}

