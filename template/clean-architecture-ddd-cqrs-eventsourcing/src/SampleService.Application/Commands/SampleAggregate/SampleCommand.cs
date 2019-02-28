using SampleService.Application.Seedwork;

namespace SampleService.Application.Commands.SampleAggregate
{
    public class SampleCommand : Command
    {
        public string SampleProperty { get; private set; }

        public SampleCommand()
        {
        }

        public SampleCommand(string sampleProperty)
        {
            this.SampleProperty = sampleProperty;
        }
    }
}