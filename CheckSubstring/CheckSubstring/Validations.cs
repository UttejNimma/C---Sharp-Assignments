using System;
namespace CheckSubstring
{
    class Validations
    {
        public string ValidateInput(string originalString)
        {
            string input;
            do
            {
                Console.Write(originalString);
                input = Console.ReadLine();

                input = input.Trim();

                if (input == null || input.Length == 0)
                {
                    Console.WriteLine("Input cannot be empty! Please try again..");
                    Console.WriteLine();
                }
                else if (IsNumeric(input))
                {
                    Console.WriteLine("Input should not be a number. Please try again..");
                    Console.WriteLine();
                }
                else if (HasDigits(input))
                {
                    Console.WriteLine("Input should not contain any digits. Please try again..");
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
            while (true);
            return input;
        }

        public bool IsNumeric(string value)
        {
            if(value == null || value.Length == 0)
            {
                return false;
            }
            
            for(int i = 0; i < value.Length; i++)
            {
                if (value[i] < '0' || value[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
        public bool HasDigits(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            foreach(char c in value)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
