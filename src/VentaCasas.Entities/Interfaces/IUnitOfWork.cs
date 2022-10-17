using System.Threading.Tasks;

namespace VentaCasas.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
}
