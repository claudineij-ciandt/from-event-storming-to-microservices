using System.Threading.Tasks;
using SampleService.Domain.Seedwork;

namespace SampleService.Application.Seedwork
{
    public interface ICommandHandlerAsync<TCommand> : IEventHandler where TCommand : ICommand
    {
        Task Handle(TCommand command);
    }

    public interface ICommandHandlerAsync<TCommand, TResult> : IEventHandler where TCommand : ICommand
    {
        Task<TResult> Handle(TCommand command);
    }
}