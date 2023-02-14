using System.Text;

namespace DirectoryTraversal
{
    class DirectoryTraversal
    {
        static void Main()
        {
            string myComputerDir = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            string inputDir = myComputerDir + "D:\\Stuff Muff";

            string outputFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\report.txt";
            Dictionary<string, List<string>> extensionsCount = new Dictionary<string, List<string>>();

            string[] filesInDir = Directory.GetFiles(inputDir);
            for(int i = 0; i < filesInDir.Length; i++)
            {
                FileInfo fileSizeInfo = new FileInfo(filesInDir[i]);
                double fileSize = (double)fileSizeInfo.Length / 1024;

                string file = filesInDir[i].Replace(inputDir + "\\", "");

                int index = file.IndexOf('.');
                string extension = file.Substring(index + 1, file.Length - index - 1).ToLower();

                string fileLine = $"{file} - {fileSize:f3}kb";

                if (!extensionsCount.ContainsKey(extension))
                {
                    extensionsCount.Add(extension, new List<string>());
                }
                extensionsCount[extension].Add(fileLine);
            }

            StringBuilder sb = new StringBuilder();          
            foreach(var extension in extensionsCount.OrderByDescending(x => x.Value.Count))
            {
                sb.AppendLine($".{extension.Key}");
                foreach(var file in extension.Value)
                {
                    sb.AppendLine($"--{file}");
                }
            }

            File.WriteAllText(outputFile, sb.ToString());
        }
    }
}