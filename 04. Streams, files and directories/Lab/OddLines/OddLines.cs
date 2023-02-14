using System;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\..\Files\Input.txt");
            using (reader)
            {
                int counter = 0;
                string line = reader.ReadLine();
                StreamWriter writer = new StreamWriter(@"..\..\..\Files\Output.txt");
                using (writer)
                {
                    while (line != null)
                    {
                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}