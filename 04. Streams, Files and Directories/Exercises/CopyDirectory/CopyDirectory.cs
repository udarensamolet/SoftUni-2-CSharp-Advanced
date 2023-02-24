namespace CopyDirectory
{
    class CopyDirectory
    {
        static void Main()
        {
            // Get input directory
            string inputDir = Console.ReadLine();

            // Get output directory
            string outputDir = Console.ReadLine();
           
            
            // Get target folder name
            int folderNameIndex = outputDir.LastIndexOf('\\');
            string folderName = outputDir.Substring(folderNameIndex + 1, outputDir.Length - folderNameIndex - 1);

            // Get list of subdirs in input directory
            List<string> inputDirList = Directory.GetDirectories(inputDir).ToList();

            // Check if the input dir exists
            foreach(var dir in inputDirList)
            {
                // Delete it, if exists
                if (dir.Contains(folderName))
                {
                    Directory.Delete(inputDir + '\\' + folderName, true);
                    break;
                }
            }
            // Create the new directory
            Directory.CreateDirectory(inputDir + '\\' + folderName);

            // Get the files from the output dir
            string[] filesInDir = Directory.GetFiles(outputDir);

            // Copy files from output dir
            for (int i = 0; i < filesInDir.Length; i++)
            {
                // Get single file info
                string sourceFile = filesInDir[i];

                // Read file info
                FileStream streamReadFile = new FileStream(sourceFile, FileMode.Open);
                byte[] buffer = new byte[streamReadFile.Length];

                // Get file name
                int fileNameIndex = sourceFile.LastIndexOf('\\');
                string fileName = sourceFile.Substring(fileNameIndex + 1, sourceFile.Length - fileNameIndex - 1);

                using (streamReadFile)
                {
                    // Copy file
                    FileStream fileCopyFile = new FileStream(inputDir + '\\' + folderName + '\\' + fileName, FileMode.Create);
                    using (fileCopyFile)
                    {
                        streamReadFile.Read(buffer, 0, buffer.Length);
                        fileCopyFile.Write(buffer, 0, buffer.Length);   
                    }
                }
            }
        }
    }
}
