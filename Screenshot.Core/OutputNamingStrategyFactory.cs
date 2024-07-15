namespace Screenshot.Core;

using Screenshot.Core.Models;
using System;

public sealed class OutputNamingStrategyFactory
{
    private readonly string fileExtension;

    public OutputNamingStrategyFactory(ImageFormat imageFormat)
    {
        Guard.ThrowIfDefault(imageFormat);
        this.fileExtension = imageFormat.ToString().ToLowerInvariant();
    }

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
