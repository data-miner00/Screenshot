namespace Screenshot.Core;

using System;

/// <summary>
/// The naming strategy that uses timestamp.
/// </summary>
public class TimestampNamingStrategy : IOutputNamingStrategy
{
    private readonly string fileExtension;

    public TimestampNamingStrategy(string fileExtension)
    {
        this.fileExtension = fileExtension;
    }

    /// <inheritdoc/>
    public string Construct()
    {
        return $"{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.{this.fileExtension}";
    }
}
