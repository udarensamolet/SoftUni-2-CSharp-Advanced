using System.Text.RegularExpressions;

namespace WordCount
{
    class WordCount
    {
        static void Main()
        {



            string[] words = File.ReadAllLines(@"..\..\..\Files\words.txt");
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                wordsCount.Add(words[i].ToLower(), 0);
            }

            string[] wordsFile = File.ReadAllLines(@"..\..\..\Files\text.txt");
            string pattern = @"[\-\.\!\?\,]";

            for (int i = 0; i < wordsFile.Length; i++)
            {
                string wordsFileCurrLine = Regex.Replace(wordsFile[i], pattern, "");
                string[] wordsFileCurrLineArr = wordsFileCurrLine
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < wordsFileCurrLineArr.Length; j++)
                {
                    if (wordsCount.ContainsKey(wordsFileCurrLineArr[j].ToLower()))
                    {
                        wordsCount[wordsFileCurrLineArr[j].ToLower()]++;
                    }
                }
            }

            int counter = 0;
            string[] outputLines = new string[words.Length];
            foreach (var word in wordsCount.OrderByDescending(x => x.Value))
            {
                outputLines[counter] = $"{word.Key} - {word.Value}";
                counter++;
            }


            File.WriteAllLines(@"..\..\..\Files\expectedResult.txt", outputLines);





        }
    }
}