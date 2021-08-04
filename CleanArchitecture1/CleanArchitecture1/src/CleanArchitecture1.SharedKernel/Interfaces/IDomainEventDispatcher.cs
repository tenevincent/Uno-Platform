using CleanArchitecture1.SharedKernel;
using System.Threading.Tasks;

namespace CleanArchitecture1.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}