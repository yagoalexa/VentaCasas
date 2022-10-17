using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace VentaCasas.Repository.DataContext
{
    public class VentaCasasContextFactory : IDesignTimeDbContextFactory<VentaCasasContext>
    {
        public VentaCasasContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<VentaCasasContext>();
            OptionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=VentaCasas;User Id=pruebas;Password=pruebas;");
            return new VentaCasasContext(OptionsBuilder.Options);
        }
    }
}
