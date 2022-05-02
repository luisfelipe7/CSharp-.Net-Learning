using System;
namespace MyThirdApplication.Application
{
    public class GenericUtilities<T> where T : IComparable, new()
    {
        public GenericUtilities()
        {
        }

        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // Max for Generic Types thanks to IComparable
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        // Create Generic object with default constructor thanks to new()1
        public void DoSomething(T value)
        {
            var obj = new T();
        }

    }
}

