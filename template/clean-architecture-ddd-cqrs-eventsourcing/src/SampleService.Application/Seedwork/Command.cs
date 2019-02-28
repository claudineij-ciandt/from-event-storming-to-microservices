using SampleService.Domain.Seedwork;

namespace SampleService.Application.Seedwork
{
    public abstract class Command : ICommand
    {
        public Header Header { get; set; }
    }
}