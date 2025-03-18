using System;
namespace FindGreatestProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxProduct maximumProduct = new MaxProduct();
            Validations validations = new Validations();

            string input = validations.ValidateInput("Enter a numeric value : ");

            long maxProduct = maximumProduct.CalculateMaxProduct(input);

            Console.WriteLine($"Maximum product of four consecutive digits is : {maxProduct}");
            Console.ReadLine();
        }
    }
}
