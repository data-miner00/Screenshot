namespace Screenshot.Core;

/// <summary>
/// The naming strategy for the output file.
/// </summary>
public interface IOutputNamingStrategy
{
    /// <summary>
    /// Construct the name of the file.
    /// </summary>
    /// <returns>The constructed file name.</returns>
    public string Construct();
}
