using System;
using System.IO;

namespace MergeFiles
{
    class MergeFiles
    {
        static void Main()
        {
            StreamReader readerInput1 = new StreamReader(@"..\..\..\Files\FileOne.txt");
            using (readerInput1)
            {
                string lineInput1 = readerInput1.ReadLine();
                StreamReader readerInput2 = new StreamReader(@"..\..\..\Files\FileTwo.txt");
                using (readerInput2)
                {
                    string lineInput2 = readerInput2.ReadLine();
                    StreamWriter writer = new StreamWriter(@"..\..\..\Files\Output.txt");

                    using (writer)
                    {
                        while (true)
                        {
                            if (lineInput1 == null && lineInput2 == null)
                            {
                                break;
                            }

                            writer.WriteLine(lineInput1);
                            writer.WriteLine(lineInput2);

                            lineInput1 = readerInput1.ReadLine();
                            lineInput2 = readerInput2.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
