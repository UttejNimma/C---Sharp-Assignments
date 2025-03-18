using System;
namespace FindGreatestProduct
{
    class Validations
    {
        public string ValidateInput(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                input = input.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input cannot be empty. Please enter input again..");
                    Console.WriteLine();
                }
                else if (input.Length <= 3)
                {
                    Console.WriteLine("Input size cannot be less than 4. Please enter input again..");
                    Console.WriteLine();
                }
                else if (!IsNumeric(input))
                {
                    Console.WriteLine("Input should be numeric value. Please enter input again..");
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            } while (true);
            return input;
        }

        public static bool IsNumeric(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Input cannot be empty. Please enter input again..");
            }

            foreach(char c in value)
            {
                if(c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
