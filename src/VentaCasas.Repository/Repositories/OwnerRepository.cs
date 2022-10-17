using VentaCasas.Entities.Interfaces;
using VentaCasas.Entities.POCOs;
using VentaCasas.Repository.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaCasas.Repository.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly VentaCasasContext _context;
        public OwnerRepository(VentaCasasContext context) =>
            _context = context;
        public async Task CreateOwner(Owner owner)
        {
            await _context.AddAsync(owner);
        }

        public async Task<Owner> GetOwner(int id)
        {
            var owner = await _context.Owner.FindAsync(id);
            return owner;
        }
    }
}
