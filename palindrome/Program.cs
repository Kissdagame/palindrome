using System;

namespace palindrome
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word and press enter");

            string input = Console.ReadLine();
            Console.WriteLine(TestString(input));
        }

        private static bool TestString(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != chars[chars.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}