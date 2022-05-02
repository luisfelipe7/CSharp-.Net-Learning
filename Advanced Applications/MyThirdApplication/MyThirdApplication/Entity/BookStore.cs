using System;
using System.Collections.Generic;
using System.Linq;

namespace MyThirdApplication.Entity
{
    public class BookStore
    {
        private readonly List<Book> Books;

        public BookStore()
        {
            this.Books = new List<Book>();
        }

        public void AddBook(Book book)
        {

            if (book == null)
            {
                throw new ArgumentNullException();
            }

            this.Books.Add(book);
        }

        public void PrintBooks(List<Book> listOfBooks)
        {
            foreach (var book in listOfBooks)
            {
                book.DisplayInformation();
            }
        }

        public void DisplayCheapBooks()
        {
            var cheapBooks = this.Books.FindAll(book => book.GetPrice() < 10);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.ToString());
            }
        }

        // Using LINQ to create different methods


        public void DisplayAvailableTitles()
        {
            var titlesAvailable = this.Books
                .Where(book => book.GetIsAvailable() == true)
                .OrderBy(book => book.GetTitle())
                .Select(book => book)
                .ToList();

            this.PrintBooks(titlesAvailable);
        }

        public void DisplayBooksHavingTitleWithOne()
        {
            var bookWithTitleOne = (from book in this.Books
                                    where book.GetTitle().Contains("1")
                                    orderby book.GetTitle()
                                    select book).ToList();

            this.PrintBooks(bookWithTitleOne);
        }

        public double GetTheMostExpensiveBook()
        {
            return this.Books.Max(book => book.GetPrice());
        }

        public void DisplayFirstBookAvailable()
        {
            var firstBook = this.Books.First(book => book.GetIsAvailable() == true);

            firstBook.DisplayInformation();
        }

        public int GetTotalBooksAvailable()
        {
            return this.Books.Sum(book => book.GetQuantityAvailable());
        }



    }
}

