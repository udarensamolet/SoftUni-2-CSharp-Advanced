using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace WordCount
{
    class WordCount
    {
        static void Main()
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            StreamReader readerWords = new StreamReader(@"..\..\..\Files\words.txt");
            using (readerWords)
            {
                string[] words = readerWords
                    .ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for(int i = 0; i < words.Length; i++)
                {
                    wordsCount.Add(words[i].ToLower(), 0);
                }

                StreamReader readerInput = new StreamReader(@"..\..\..\Files\text.txt");
                using (readerInput)
                {
                    string line = readerInput.ReadLine();
                    while (line != null)
                    {
                        string[] lineWords = line
                            .Split(new char[] { ' ', ',', '-', '?', '!', '.'}, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
                        foreach (var word in lineWords)
                        {
                            if (wordsCount.ContainsKey(word.ToLower()))
                            {
                                wordsCount[word.ToLower()]++;
                            }
                        }
                        line = readerInput.ReadLine();
                    }
                }
            }

            StreamWriter writer = new StreamWriter(@"..\..\..\Files\Output.txt");
            using (writer)
            {
                foreach (var word in wordsCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }

            
        }
    }
}
