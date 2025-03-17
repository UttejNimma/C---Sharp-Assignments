using System;
namespace Assignment
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter string s1:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter string s2:");
            string s2 = Console.ReadLine();
            Console.WriteLine();
            int count = 0;
            int length = s2.Length;
            for(int i = 0; i <= s1.Length-length; i++)
            {
                if(s1.Substring(i, length) == s2)
                {
                    count++;
                    Console.WriteLine("Index position: " + i);
                }
            }
            if (count > 0)
            {
                Console.WriteLine($"Number of times {s2} occured in {s1} is : {count}");
            }
            else
            {
                Console.WriteLine($"{s2} is not substring of {s1}");
            }
            Console.ReadLine();
        }
    }
}
