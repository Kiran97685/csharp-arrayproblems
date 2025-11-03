using System;

namespace CSharpCodingChallenge
{
    internal class DuplicateCharacters
    {
        public void FindDuplicateCharacters()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            input = input.ToLower();   // optional

            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                // Ignore spaces, digits, punctuation
                if (!char.IsLetter(chars[i]))
                    continue;

                int count = 1;

                // Skip already counted
                if (chars[i] == '0')
                    continue;

                for (int j = i + 1; j < chars.Length; j++)
                {
                    if (chars[i] == chars[j])
                    {
                        count++;
                        chars[j] = '0';   // mark as counted
                    }
                }

                Console.WriteLine($"{chars[i]} - {count}");
            }
        }
    }
}
