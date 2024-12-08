namespace Screenshot.Core;

using System.IO;

/// <summary>
/// The implementation for file info repository. This class is too broad and will need to be specialized.
/// </summary>
public sealed class FileInfoRepository : IFileInfoRepository
{
    /// <inheritdoc/>
    public FileInfo[] GetFileInfo(string folderPath)
    {
        var directoryInfo = new DirectoryInfo(folderPath);

        return directoryInfo.GetFiles();
    }
}
