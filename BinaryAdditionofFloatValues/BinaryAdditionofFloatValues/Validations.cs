using System;
namespace BinaryAdditionofFloatValues
{
    public class Validations
    {
        public (int, float) ParseNumber(string prompt)
        {

            String[] parts = { };
            do
            {
                Console.Write(prompt);
                String number = Console.ReadLine();
                parts = number.Split('.');
                if (parts.Length != 2) Console.WriteLine("Invalid input format.");
            } while (parts.Length != 2);
            int intPart = int.Parse(parts[0]);
            float fracPart = float.Parse("0." + parts[1]);
            return (intPart, fracPart);
        }
        public string PadBinary(string binary, int length)
        {
            return binary.PadRight(length, '0');
        }
        public (string, string) SplitBinarySum(string sumBinary, int fractionLength)
        {
            string integerPart = sumBinary.Substring(0, sumBinary.Length - fractionLength);
            string fractionPart = sumBinary.Substring(sumBinary.Length - fractionLength);
            return (integerPart, fractionPart);
        }
    }
}
