using System.Collections.Generic;
using Clean.Architecture.Core.Repository;

namespace Clean.Architecture.Core.Services
{
    public interface IExampleService
    {
        IEnumerable<string> Get();
    }

    public class ExampleService : IExampleService
    {
        private readonly IExampleRepository repository;
        
        public ExampleService(IExampleRepository repository)
        {
            this.repository = repository;

        }

        public IEnumerable<string> Get()
        {
            return repository.Get();
        }
    }
}