namespace Screenshot.Core;

using System;

/// <summary>
/// The naming strategy that uses <see cref="Guid"/>.
/// </summary>
public sealed class GuidNamingStrategy : IOutputNamingStrategy
{
    private readonly string fileExtension;

    public GuidNamingStrategy(string fileExtension)
    {
        this.fileExtension = fileExtension;
    }

    /// <inheritdoc/>
    public string Construct()
    {
        return $"{Guid.NewGuid()}.{this.fileExtension}";
    }
}
