namespace Core.Events;

public interface IEvent
{
    Guid Id { get; }
    DateTime CreationDate { get; }
    IDictionary<string, object> MetaData { get; }
}
