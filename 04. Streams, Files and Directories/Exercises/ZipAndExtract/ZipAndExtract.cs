using System.IO.Compression;

namespace ZipAndExtract
{
    class ZipAndExtract
    {
        static void Main()
        {
            string startPath = @"..\..\..\Files";
            string zipPath = startPath + "\\result.zip";
            string extractPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            ZipFile.CreateFromDirectory(startPath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}