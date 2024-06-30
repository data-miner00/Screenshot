namespace Screenshot.Core;

using System;

public sealed class OutputNamingStrategyFactory
{
    private readonly string fileExtension;
    private string namingStrategy;

    public OutputNamingStrategyFactory(string fileExtension)
    {
        this.fileExtension = fileExtension;
    }

    public IOutputNamingStrategy Create(string namingStrategy)
    {
        this.namingStrategy = namingStrategy;

        return namingStrategy switch
        {
            "guid" => new GuidNamingStrategy(this.fileExtension),
            "timestamp" => new TimestampNamingStrategy(this.fileExtension),
            _ => throw new NotSupportedException(),
        };
    }
}
