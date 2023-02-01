using System;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;

            Console.WriteLine("type a word or phrase to check!");
            word = Console.ReadLine();
            int x = word.Length - 1;

            while (x != -1)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == word[x])
                    {
                        if (x == 0)
                        {
                            Console.WriteLine("It's a  Palindrome");
                            Console.ReadLine();
                        }
                        x--;

                    }
                    else
                    {
                        Console.WriteLine("It's not a Palindrome!");
                        i = word.Length;
                        x = -1;
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}

