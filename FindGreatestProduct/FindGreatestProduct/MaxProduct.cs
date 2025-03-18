using System;
namespace FindGreatestProduct
{
    class MaxProduct
    {
        public long CalculateMaxProduct(string input)
        {
            long maxiProduct = 0;

            char[] digits = input.ToCharArray();
           
            for (int i = 0; i <= digits.Length - 4; i++)
            {
                long product = 1;
                for (int j = i; j < (i + 4); j++)
                {
                    product *= (digits[j] - '0');
                }

                maxiProduct = Math.Max(maxiProduct, product);
                //if (product > maxiProduct)
                //{
                //    maxiProduct = product;
                //}
            }
            return maxiProduct;
           
        }
    }
}
