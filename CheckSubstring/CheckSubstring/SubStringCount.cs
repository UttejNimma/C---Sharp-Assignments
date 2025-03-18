using System;
namespace CheckSubstring
{
    class SubStringCount
    {
        public (int[], int) SubstringOccurrences(string originalString, string subString)
        {
            int initialCapacity = originalString.Length; 
            int[] positions = new int[initialCapacity];
            int count = 0;

            for (int index = 0; index <= originalString.Length - subString.Length; index++)
            {
                int matchLength = 0;
                
                while (matchLength < subString.Length && originalString[index + matchLength] == subString[matchLength])
                {
                    matchLength++;
                }
       
                if (matchLength == subString.Length)
                {
                    positions[count] = index;
                    count++;
                }
            }
            return (positions, count);
        }
    }
}
