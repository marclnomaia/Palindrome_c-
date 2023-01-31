using System;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;

            Console.WriteLine("type a word or phrase!");
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
                            Console.WriteLine("E Palindrome");
                            Console.ReadLine();
                        }
                        x--;

                    }
                    else
                    {
                        Console.WriteLine("Nao e Palindrome!");
                        i = word.Length;
                        x = -1;
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}

