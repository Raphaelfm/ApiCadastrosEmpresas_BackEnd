using ApiEmpresas.Data;
using ApiEmpresas.Interfaces;
using ApiEmpresas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEmpresas.Repositories
{
    public class EmpresasRepository : IEmpresasRepository
    {
        private readonly EmpresasDbContext _context;

        public EmpresasRepository(EmpresasDbContext context)
        {
            _context = context;
        }

        public void AdicionarEmpresa(EmpresaModel empresa)
        {
            _context.Set<EmpresaModel>().Add(empresa);
        }

        public void ExcluirEmpresa(int id)
        {
            var empresa = _context.Set<EmpresaModel>().Find(id);

            if (empresa != null)
            {
                _context.Set<EmpresaModel>().Remove(empresa);
            }
        }

        public List<EmpresaModel> ListaEmpresas()
        {
            return _context.Set<EmpresaModel>().ToList();
        }

        public EmpresaModel EmpresaPorId(int id)
        {
            var empresa = _context.Set<EmpresaModel>().FirstOrDefault(e => e.Id == id);
           
            return empresa;
        }

        public void AtualizarEmpresa(EmpresaModel empresa)
        {
            _context.Entry(empresa).State = EntityState.Modified;
        }

        public void SalvarAlteracoes()
        {
            _context.SaveChanges();
        }
    }
}
