using System.Threading.Tasks;
using SampleService.Domain.Seedwork;

namespace SampleService.Application.Seedwork
{
    public interface IIntegrationEventHandlerAsync<TIntegrationEvent> : IEventHandler where TIntegrationEvent : IDomainEvent
    {
        Task Handle(TIntegrationEvent integrationEvent);
    }

    public interface IIntegrationEventHandlerAsync<TIntegrationEvent, TResult> : IEventHandler where TIntegrationEvent : IDomainEvent
    {
        Task<TResult> Handle(TIntegrationEvent integrationEvent);
    }
}