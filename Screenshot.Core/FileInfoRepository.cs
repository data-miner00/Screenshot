namespace Screenshot.Core;

using System.IO;

public sealed class FileInfoRepository : IFileInfoRepository
{
    public FileInfo[] GetFileInfo(string folderPath)
    {
        var directoryInfo = new DirectoryInfo(folderPath);

        var files = directoryInfo.GetFiles();

        return files;
    }
}
