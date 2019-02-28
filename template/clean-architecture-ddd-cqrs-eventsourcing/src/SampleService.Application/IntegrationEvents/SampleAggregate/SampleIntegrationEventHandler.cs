using System.Threading.Tasks;
using SampleService.Application.Seedwork;

namespace SampleService.Application.IntegrationEvents.SampleAggregate
{
    public class SampleIntegrationEventHandler : IIntegrationEventHandlerAsync<SampleIntegrationEvent, string>
    {
        public Task<string> Handle(SampleIntegrationEvent integrationEvent)
        {
            throw new System.NotImplementedException();
        }
    }
}