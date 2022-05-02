using System;
namespace MyThirdApplication.Entity
{
    public class Book
    {
        private readonly string Title;
        private double Price;
        private int QuantityAvailable;
        private bool IsAvailable;

        public Book(string Title, double Price, int QuantityAvailable)
        {
            this.Title = Title;
            this.Price = Price;
            this.QuantityAvailable = QuantityAvailable;
            if (this.QuantityAvailable > 0)
            {
                this.IsAvailable = true;
            }
            else
            {
                this.IsAvailable = false;
            }
        }

        public double GetPrice()
        {
            return this.Price;
        }

        public bool GetIsAvailable()
        {
            return this.IsAvailable;
        }

        public string GetTitle()
        {
            return this.Title;
        }

        public int GetQuantityAvailable()
        {
            return this.QuantityAvailable;
        }

        public void DisplayInformation()
        {
            Console.WriteLine("-- Book Information --");
            Console.WriteLine("-Title: " + this.Title);
            Console.WriteLine("-Price: " + this.Price);
            Console.WriteLine("-QuantityAvailable: " + this.QuantityAvailable);
        }

    }
}

