using System;
using System.Globalization;
namespace Assignment
{
    class GreatestProduct
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            string number = Console.ReadLine();
            if (String.IsNullOrEmpty(number))
            {
                Console.WriteLine("Invalid input");
            }

            if (number.Length < 4)
            {
                Console.WriteLine("The number must have at least 4 digits.");
                Console.ReadLine();
                return;
            }
            char[] digits = number.ToCharArray();
            long maxProduct = 0;
            for (int i = 0; i <= digits.Length - 4; i++)
            {
                long product = 1;
                for (int j = i; j < (i + 4); j++)
                {
                    product *= (digits[j] - '0');
                }
                if (product > maxProduct)
                {
                    maxProduct = product;
                }
            }
            Console.WriteLine($"Max product of four adjacent digits is : {maxProduct}");
            Console.ReadLine();
        }
    }
}