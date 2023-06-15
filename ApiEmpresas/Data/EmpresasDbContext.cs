using ApiEmpresas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEmpresas.Data
{
    public class EmpresasDbContext : DbContext
    {
        public EmpresasDbContext(DbContextOptions<EmpresasDbContext> options) : base(options) { }

        public DbSet<EmpresaModel> EmpresasModel { get; set; }
    }
}
