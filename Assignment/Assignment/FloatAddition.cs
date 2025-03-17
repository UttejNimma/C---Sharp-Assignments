using System;
namespace Assignment
{
    class FloatAddition
    {
        public static void Main(string[] args)
        {
            // Take two float inputs from the user
            Console.Write("Enter the first float number: ");
            float n = float.Parse(Console.ReadLine());

            Console.Write("Enter the second float number: ");
            float m = float.Parse(Console.ReadLine());

            // Convert the floats to binary representation
            string binaryN = FloatToBinary(n);
            string binaryM = FloatToBinary(m);

            // Print the binary representations
            Console.WriteLine($"Binary representation of {n} is: {binaryN}");
            Console.WriteLine($"Binary representation of {m} is: {binaryM}");

            // Perform binary addition
            string resultBinary = BinaryAddition(binaryN, binaryM);

            // Print the binary result
            Console.WriteLine($"Binary result of addition: {resultBinary}");

            // Convert the binary result back to float
            float result = BinaryToFloat(resultBinary);

            // Print the result as a float
            Console.WriteLine($"Result as float: {result}");
            Console.ReadLine();
        }

        // Method to convert float to binary string
        static string FloatToBinary(float num)
        {
            // Split the number into integer and fractional parts
            int integerPart = (int)num;
            float fractionalPart = num - integerPart;

            // Convert the integer part to binary
            string integerBinary = ConvertIntegerToBinary(integerPart);

            // Convert the fractional part to binary
            string fractionalBinary = ConvertFractionalToBinary(fractionalPart);

            // Combine both parts
            return integerBinary + fractionalBinary;
        }

        // Method to convert integer part to binary
        static string ConvertIntegerToBinary(int integer)
        {
            string binary = "";
            while (integer > 0)
            {
                binary = (integer % 2) + binary;
                integer /= 2;
            }
            return binary == "" ? "0" : binary;
        }

        // Method to convert fractional part to binary
        static string ConvertFractionalToBinary(float fractional)
        {
            string binary = ".";
            while (fractional > 0)
            {
                fractional *= 2;
                int integerPart = (int)fractional;
                binary += integerPart.ToString();
                fractional -= integerPart;

                // Limit the precision to avoid infinite loop for non-terminating fractions
                if (binary.Length > 32) break;
            }
            return binary;
        }

        // Method to perform binary addition on two binary strings
        static string BinaryAddition(string binary1, string binary2)
        {
            // Align the binary numbers to the same length by padding with leading zeros
            int maxLength = Math.Max(binary1.Length, binary2.Length);
            binary1 = binary1.PadLeft(maxLength, '0');
            binary2 = binary2.PadLeft(maxLength, '0');

            int carry = 0;
            string result = "";

            // Perform binary addition bit by bit starting from the rightmost bit
            for (int i = maxLength - 1; i >= 0; i--)
            {
                int bit1 = binary1[i] == '1' ? 1 : 0;
                int bit2 = binary2[i] == '1' ? 1 : 0;

                int sum = bit1 + bit2 + carry;

                if (sum == 0)
                {
                    result = "0" + result;
                    carry = 0;
                }
                else if (sum == 1)
                {
                    result = "1" + result;
                    carry = 0;
                }
                else if (sum == 2)
                {
                    result = "0" + result;
                    carry = 1;
                }
                else if (sum == 3)
                {
                    result = "1" + result;
                    carry = 1;
                }
            }

            // If there's a carry left, prepend it
            if (carry == 1)
            {
                result = "1" + result;
            }

            return result;
        }

        // Method to convert binary string back to float
        static float BinaryToFloat(string binary)
        {
            int integerPart = 0;
            float fractionalPart = 0;
            int i = 0;

            // Process the integer part
            while (i < binary.Length && binary[i] != '.')
            {
                integerPart = integerPart * 2 + (binary[i] == '1' ? 1 : 0);
                i++;
            }

            // Process the fractional part
            i++; // Skip the dot
            float fractionalValue = 0.5f;
            while (i < binary.Length)
            {
                if (binary[i] == '1')
                {
                    fractionalPart += fractionalValue;
                }
                fractionalValue /= 2;
                i++;
            }

            // Combine the integer and fractional parts
            return integerPart + fractionalPart;
        }
    }
}
