namespace BinaryAdditionofFloatValues
{
    public class BinaryCalculator
    {
        public string IntToBinary(int number)
        {
            if (number == 0) return "0";

            string result = "";
            while (number > 0)
            {
                result = (number % 2) + result;
                number /= 2;
            }
            return result;
        }
        public string FloatToBinary(float number)
        {
            if (number == 0) return "0";

            string binary = "";
            while (number > 0)
            {
                number *= 2;
                if (number >= 1)
                {
                    binary += "1";
                    number -= 1;
                }
                else
                {
                    binary += "0";
                }
            }
            return binary;
        }
        public string AddBinary(string firstBin, string secondBin)
        {
            string result = "";
            int carry = 0;
            int i = firstBin.Length - 1;
            int j = secondBin.Length - 1;

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry;
                if (i >= 0) sum += firstBin[i] - '0';
                if (j >= 0) sum += secondBin[j] - '0';
                result = (sum % 2) + result;
                carry = sum / 2;
                i--;
                j--;
            }

            return result;
        }
        public int BinaryToInt(string binary)
        {
            int result = 0;
            int power = 1;

            for (int index = binary.Length - 1; index >= 0; index--)
            {
                int digit = binary[index] - '0';
                result += digit * power;
                power *= 2;
            }

            return result;
        }
        public float BinaryToFloat(string binary)
        {
            float result = 0;
            float power = 0.5f;

            foreach (char c in binary)
            {
                if (c == '1')
                {
                    result += power;
                }
                power /= 2;
            }

            return result;
        }
    }
}
