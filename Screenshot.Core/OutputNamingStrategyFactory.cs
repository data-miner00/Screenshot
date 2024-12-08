namespace Screenshot.Core;

using Screenshot.Core.Models;
using System;

/// <summary>
/// The factory for creating <see cref="IOutputNamingStrategy"/> implementations.
/// </summary>
public sealed class OutputNamingStrategyFactory
{
    private readonly string fileExtension;

    /// <summary>
    /// Initializes a new instance of the <see cref="OutputNamingStrategyFactory"/> class.
    /// </summary>
    /// <param name="imageFormat">The image format.</param>
    public OutputNamingStrategyFactory(ImageFormat imageFormat)
    {
        Guard.ThrowIfDefault(imageFormat);
        this.fileExtension = imageFormat.ToString().ToLowerInvariant();
    }

    /// <summary>
    /// Creates the concrete instance of <see cref="IOutputNamingStrategy"/>.
    /// </summary>
    /// <param name="namingStrategy">The naming strategy type.</param>
    /// <returns>The output naming strategy implementation.</returns>
    /// <exception cref="NotSupportedException">Throws when unsupported <see cref="NamingStrategies"/> was supplied.</exception>
    public IOutputNamingStrategy Create(NamingStrategies namingStrategy)
    {
        return namingStrategy switch
        {
            NamingStrategies.Guid => new GuidNamingStrategy(this.fileExtension),
            NamingStrategies.Timestamp => new TimestampNamingStrategy(this.fileExtension),
            _ => throw new NotSupportedException(),
        };
    }
}
