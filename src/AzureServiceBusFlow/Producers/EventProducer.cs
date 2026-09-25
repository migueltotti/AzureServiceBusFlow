using AzureServiceBusFlow.Abstractions;
using AzureServiceBusFlow.Models;

namespace AzureServiceBusFlow.Producers
{
    public class EventProducer<TEvent>(IServiceBusProducer<TEvent> producer) : IEventProducer<TEvent> where TEvent : class, IServiceBusMessage
    {
        private readonly IServiceBusProducer<TEvent> _producer = producer;

        public Task ProduceEventAsync(TEvent @event, CancellationToken cancellationToken)
        {
            return _producer.ProduceAsync(@event, cancellationToken);
        }

        public Task ProduceEventAsync(TEvent @event, MessageOptions messageOptions, CancellationToken cancellationToken)
        {
            return _producer.ProduceAsync(@event, messageOptions, cancellationToken);
        }

        public Task ProduceEventAsync(TEvent @event, IDictionary<string, object> applicationProperties, CancellationToken cancellationToken)
        {
            return _producer.ProduceAsync(@event, applicationProperties, cancellationToken);
        }

        public Task ProduceEventAsync(TEvent @event, TimeSpan delay, CancellationToken cancellationToken)
        {
            return _producer.ProduceAsync(@event, delay, cancellationToken);
        }

        public Task ProduceEventAsync(TEvent @event, string sessionId, CancellationToken cancellationToken)
        {
            return _producer.ProduceAsync(@event, sessionId, cancellationToken);
        }
    }
}
