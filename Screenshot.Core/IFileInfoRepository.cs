namespace Screenshot.Core;

using System.IO;

/// <summary>
/// The abstraction for the repository that store file info data.
/// </summary>
public interface IFileInfoRepository
{
    /// <summary>
    /// Retrieves the file info from a folder.
    /// </summary>
    /// <param name="folderPath">The folder path.</param>
    /// <returns>The existing files.</returns>
    public FileInfo[] GetFileInfo(string folderPath);
}
