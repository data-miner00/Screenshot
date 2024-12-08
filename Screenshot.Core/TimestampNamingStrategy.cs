namespace Screenshot.Core;

using System;

/// <summary>
/// The naming strategy that uses timestamp.
/// </summary>
public sealed class TimestampNamingStrategy : IOutputNamingStrategy
{
    private readonly string fileExtension;

    /// <summary>
    /// Initializes a new instance of the <see cref="TimestampNamingStrategy"/> class.
    /// </summary>
    /// <param name="fileExtension">The file extension.</param>
    public TimestampNamingStrategy(string fileExtension)
    {
        this.fileExtension = Guard.ThrowIfNullOrWhitespace(fileExtension);
    }

    /// <inheritdoc/>
    public string Construct()
    {
        return $"{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.{this.fileExtension}";
    }
}
