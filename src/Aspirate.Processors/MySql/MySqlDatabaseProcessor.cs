namespace Aspirate.Processors.MySql;

public class MySqlDatabaseProcessor(IFileSystem fileSystem, IAnsiConsole console) : BaseProcessor<MySqlDatabaseTemplateData>(fileSystem, console)
{
    /// <inheritdoc />
    public override string ResourceType => AspireComponentLiterals.MySqlDatabase;

    /// <inheritdoc />
    public override Resource? Deserialize(ref Utf8JsonReader reader) =>
        JsonSerializer.Deserialize<MySqlDatabase>(ref reader);

    public override Task<bool> CreateManifests(KeyValuePair<string, Resource> resource, string outputPath, string imagePullPolicy,
        string? templatePath = null, bool? disableSecrets = false) =>
        // Do nothing for databases, they are there for configuration.
        Task.FromResult(true);
}
