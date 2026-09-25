using AzureServiceBusFlow.Models;

namespace AzureServiceBusFlow.Abstractions
{
    public interface IEventProducer<in TEvent> where TEvent : class, IServiceBusMessage
    {
        Task ProduceEventAsync(TEvent @event, CancellationToken cancellationToken);
        Task ProduceEventAsync(TEvent @event, MessageOptions messageOptions, CancellationToken cancellationToken);
        Task ProduceEventAsync(TEvent @event, IDictionary<string, object> applicationProperties, CancellationToken cancellationToken);
        Task ProduceEventAsync(TEvent @event, TimeSpan delay, CancellationToken cancellationToken);
        Task ProduceEventAsync(TEvent @event, string sessionId, CancellationToken cancellationToken);
    }
}
