using Core;

namespace Api.Domain;

public class ImportItem : AggregateRoot<Guid>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> SearchableKeywords { get; set; } = new();
    public object? MetaData { get; set; } = default;
}
