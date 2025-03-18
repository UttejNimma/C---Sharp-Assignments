using System;
namespace BinaryAdditionofFloatValues
{
    public class Program
    {
        static void Main(string[] args)
        {
            Validations validation = new Validations();
            BinaryCalculator calculator = new BinaryCalculator();

            (int firstInteger, float firstFractional) = validation.ParseNumber("Enter the first number (format: integer.fraction): ");
            Console.WriteLine();
            (int secondInteger, float secondFractional) = validation.ParseNumber("Enter the second number (format: integer.fraction): ");
            Console.WriteLine();

            string firstBinaryInt = calculator.IntToBinary(firstInteger);
            string firstBinaryFrac = calculator.FloatToBinary(firstFractional);
            string secondBinaryInt = calculator.IntToBinary(secondInteger);
            string secondBinaryFrac = calculator.FloatToBinary(secondFractional);

            int maxFractionLength = Math.Max(firstBinaryFrac.Length, secondBinaryFrac.Length);

            string firstPaddedFrac = validation.PadBinary(firstBinaryFrac, maxFractionLength);
            string secondPaddedFrac = validation.PadBinary(secondBinaryFrac, maxFractionLength);

            string firstCombined = firstBinaryInt + firstPaddedFrac;
            string secondCombined = secondBinaryInt + secondPaddedFrac;

            
            string binarySum = calculator.AddBinary(firstCombined, secondCombined);

            
            (string sumIntegerPart, string sumFractionPart) = validation.SplitBinarySum(binarySum, maxFractionLength);

            // Convert back to integer and fractional parts
            int integerPart = calculator.BinaryToInt(sumIntegerPart);
            float fractionalPart = calculator.BinaryToFloat(sumFractionPart);

            Console.WriteLine($"Final result: {integerPart + fractionalPart}");
            Console.ReadLine();

        }
    }
}
