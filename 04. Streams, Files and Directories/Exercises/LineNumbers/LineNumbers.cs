using System.Text.RegularExpressions;
using System.IO;
using System.Text;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            string[] fileLines = File.ReadAllLines(@"..\..\..\text.txt");
            string[] outputFileLines = new string[fileLines.Length];

            string patternLetters = @"[A-Za-z]";
            string patternPunctuationMarks = @"[^A-Za-z0-9\s]";

            for (int i = 0; i < fileLines.Length; i++)
            {
                int lettersCount = 0;
                int punctuationMarksCount = 0;

                Regex regexLetters = new Regex(patternLetters);
                Regex regexPunctuationMarks = new Regex(patternPunctuationMarks);

                MatchCollection matchesLetters = regexLetters.Matches(fileLines[i]);
                MatchCollection matchesPunctuationMarks = regexPunctuationMarks.Matches(fileLines[i]);

                lettersCount = matchesLetters.Count;
                punctuationMarksCount = matchesPunctuationMarks.Count;

                outputFileLines[i] = $"Line {i + 1}: {fileLines[i]} ({lettersCount})({punctuationMarksCount})";
            }
            File.WriteAllLines(@"..\..\..\output.txt", outputFileLines);
        }
    }
}