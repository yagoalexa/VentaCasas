using Microsoft.EntityFrameworkCore;
using VentaCasas.Entities.Interfaces;
using VentaCasas.Entities.POCOs;
using VentaCasas.Repository.DataContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VentaCasas.Repository.Repositories
{
    public class PropertyImageRepository : IPropertyImageRepository
    {
        private readonly VentaCasasContext _context;
        public PropertyImageRepository(VentaCasasContext context) =>
            _context = context;
        public void AddImageProperty(PropertyImage propertyImage)
        {
            _context.Add(propertyImage);
        }

        public async Task<IEnumerable<PropertyImage>> GetImageProperties(int propertyId)
        {
            return await _context.PropertyImage.Where(w => w.PropertyId == propertyId).ToListAsync();
        }
    }
}
