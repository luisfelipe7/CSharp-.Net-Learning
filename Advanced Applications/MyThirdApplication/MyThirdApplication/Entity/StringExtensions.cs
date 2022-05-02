using System;
using System.Linq;

namespace MyThirdApplication.Entity
{
    public static class StringExtensions
    {
        public static string ConvertToPascalCase(this String str)
        {
            string[] arrayOfStrings = str.Split(" ");
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                var tempCharArray = arrayOfStrings[i].ToCharArray();
                tempCharArray[0] = Char.ToUpper(tempCharArray[0]);
                arrayOfStrings[i] = new String(tempCharArray);
            }
            return String.Join("", arrayOfStrings);

        }
    }
}

