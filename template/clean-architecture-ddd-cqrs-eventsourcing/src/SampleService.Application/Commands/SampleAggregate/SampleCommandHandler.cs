using System.Threading.Tasks;
using SampleService.Application.IntegrationEvents.SampleAggregate;
using SampleService.Application.Seedwork;

namespace SampleService.Application.Commands.SampleAggregate
{
    public class SampleCommandHandler : ICommandHandlerAsync<SampleCommand, string>
    {
        public Task<string> Handle(SampleCommand sampleCommand)
        {
            throw new System.NotImplementedException();
        }
    }
}