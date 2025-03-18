using System;
namespace CheckSubstring
{
    class Program
    {
        public static void Main()
        {
            SubStringCount subStringCount = new SubStringCount();
            Validations validations = new Validations();
            string originalString = validations.ValidateInput("Enter the original string: ");
            Console.WriteLine();
            string subString = validations.ValidateInput("Enter the substring string: ");
            Console.WriteLine();

            (int[] positions, int count) = subStringCount.SubstringOccurrences(originalString, subString);

            Console.WriteLine("Number of occurrences = " + count);
            if (count > 0)
            {
                Console.Write($"substring {subString} occured in original string {originalString} at indexes = ");
                for (int index = 0; index < count; index++)
                {
                    Console.Write(positions[index] + " ");
                }
            }
            else
            {
                Console.WriteLine("substring not found in original string.");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
