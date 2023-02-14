namespace CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main()
        {
            string sourceFile = @"..\..\..\Files\CopyMe.png";
            string destinationDirectory = @"..\..\..\Files\Copied.png";

            FileStream streamReadFile = new FileStream(sourceFile, FileMode.Open);
            byte[] buffer = new byte[streamReadFile.Length];

            using (streamReadFile)
            {
                FileStream fileCopyFile = new FileStream(destinationDirectory, FileMode.Create);
                using (fileCopyFile)
                {
                    streamReadFile.Read(buffer, 0, buffer.Length);
                    fileCopyFile.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}