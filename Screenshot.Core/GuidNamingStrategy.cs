namespace Screenshot.Core;

using System;

/// <summary>
/// The naming strategy that uses <see cref="Guid"/>.
/// </summary>
public sealed class GuidNamingStrategy : IOutputNamingStrategy
{
    private readonly string fileExtension;

    /// <summary>
    /// Initializes a new instance of the <see cref="GuidNamingStrategy"/> class.
    /// </summary>
    /// <param name="fileExtension">The file extension.</param>
    public GuidNamingStrategy(string fileExtension)
    {
        this.fileExtension = Guard.ThrowIfNullOrWhitespace(fileExtension);
    }

    /// <inheritdoc/>
    public string Construct()
    {
        return $"{Guid.NewGuid()}.{this.fileExtension}";
    }
}
