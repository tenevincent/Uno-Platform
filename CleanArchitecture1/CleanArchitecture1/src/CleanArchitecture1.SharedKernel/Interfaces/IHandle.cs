using CleanArchitecture1.SharedKernel;
using System.Threading.Tasks;

namespace CleanArchitecture1.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}