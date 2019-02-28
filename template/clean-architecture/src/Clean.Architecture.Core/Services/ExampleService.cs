using System.Collections.Generic;
using Clean.Architecture.Core.Model;
using Clean.Architecture.Core.Repository;

namespace Clean.Architecture.Core.Services
{
    public interface IExampleService
    {
        IEnumerable<Example> Get();
    }

    public class ExampleService : IExampleService
    {
        private readonly IExampleRepository repository;
        
        public ExampleService(IExampleRepository repository)
        {
            this.repository = repository;

        }

        public IEnumerable<Example> Get()
        {
            return repository.Get();
        }
    }
}