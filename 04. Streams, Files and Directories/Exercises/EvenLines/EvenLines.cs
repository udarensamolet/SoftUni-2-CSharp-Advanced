using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace EvenLines
{
    public class EvenLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\..\text.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                string patternReplace = @"[\-\,\.\!\?]";
                string patternReplacing = @"@";
                int counter = 0;
                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                        line = Regex.Replace(line, patternReplace, patternReplacing);
                        StringBuilder sb = new StringBuilder();
                        string[] lineArr =
                            line
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

                        for (int i = lineArr.Length - 1; i >= 0; i--)
                        {
                            sb.Append(lineArr[i]);
                            sb.Append(" ");
                        }
                        Console.WriteLine(sb.ToString().TrimEnd());
                       
                    }
                    line = reader.ReadLine();
                    counter++;
                }
            }
        }
    }
}