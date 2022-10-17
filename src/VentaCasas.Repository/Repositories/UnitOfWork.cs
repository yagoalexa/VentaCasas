using VentaCasas.Entities.Interfaces;
using VentaCasas.Repository.DataContext;
using System.Threading.Tasks;

namespace VentaCasas.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VentaCasasContext _context;
        public UnitOfWork(VentaCasasContext context) =>
            _context = context;
        public Task<int> SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}
