using VentaCasas.Entities.POCOs;
using System.Threading.Tasks;

namespace VentaCasas.Entities.Interfaces
{
    public interface IOwnerRepository
    {
        Task CreateOwner(Owner owner);
        Task<Owner> GetOwner(int id);
    }
}
