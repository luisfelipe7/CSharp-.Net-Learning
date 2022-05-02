using System;
using System.Collections.Generic;

namespace MyThirdApplication.Entity
{
    public class MyCalculator
    {
        private readonly int[] Numbers;

        public MyCalculator()
        {
            this.Numbers = new int[10];
        }

        // Creating an Indexer
        public int this[int index]
        {
            get => this.Numbers[index];
            set => this.Numbers[index] = value;
        }




    }
}

