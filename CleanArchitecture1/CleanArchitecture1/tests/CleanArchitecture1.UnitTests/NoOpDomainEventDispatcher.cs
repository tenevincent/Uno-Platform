using CleanArchitecture1.SharedKernel;
using CleanArchitecture1.SharedKernel.Interfaces;
using System.Threading.Tasks;

namespace CleanArchitecture1.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
