using System;

namespace Word_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToLower();
            var n = int.Parse(Console.ReadLine());
            var results = new bool[n];
            for (int i = 0; i < n; i++)
            {
                var wordToCheck = Console.ReadLine().ToLower();
                var baseWord = word;
                results[i] = true;

                if (wordToCheck.Length == word.Length)
                {
                    for (int j = 0; j < baseWord.Length; j++)
                    {
                        for (int h = 0; h < wordToCheck.Length; h++)
                        {
                            if (baseWord[j] == wordToCheck[h])
                            {
                                wordToCheck = wordToCheck.Remove(h, 1);
                            }
                        }
                    }
                }
                else
                {
                    results[i] = false;
                }

                if(wordToCheck.Length != 0)
                {
                    results[i] = false;
                }
            }
            foreach (var check in results)
            {
                if(check)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
