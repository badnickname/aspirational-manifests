namespace Aspirate.Processors.Redis;

public sealed class RedisTemplateData(IReadOnlyCollection<string> manifests)
    : BaseTemplateData(null, null, null, manifests, false);