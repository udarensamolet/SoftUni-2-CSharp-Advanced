using System;
using System.IO;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\..\Files\Input.txt");
            using (reader)
            {
                int counter = 1;
                string line = reader.ReadLine();
                StreamWriter writer = new StreamWriter(@"..\..\..\Files\Output.txt");
                using (writer)
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{counter}. {line}");
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
