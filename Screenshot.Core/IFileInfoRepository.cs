namespace Screenshot.Core;

using System.IO;

public interface IFileInfoRepository
{
    public FileInfo[] GetFileInfo(string folderPath);
}
