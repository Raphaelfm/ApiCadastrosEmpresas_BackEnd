using ApiEmpresas.Data;
using ApiEmpresas.Interfaces;
using ApiEmpresas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEmpresas.Repositories
{
    /// <summary>
    /// Empresa Repository
    /// Faz o acesso ao banco de dados para devolver ao controller
    /// </summary>
    public class EmpresasRepository : IEmpresasRepository
    {
        private readonly EmpresasDbContext _context;

        public EmpresasRepository(EmpresasDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Adiciona empresas
        /// </summary>
        /// <param name="empresa"></param>
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

        /// <summary>
        /// Lista todas as empresas
        /// </summary>
        /// <returns></returns>
        public List<EmpresaModel> ListaEmpresas()
        {
            return _context.Set<EmpresaModel>().ToList();
        }


        /// <summary>
        /// Retorna uma empresa conforme o id informado pelo usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public EmpresaModel EmpresaPorId(int id)
        {
            var empresa = _context.Set<EmpresaModel>().FirstOrDefault(e => e.Id == id);
           
            return empresa;
        }

        /// <summary>
        /// Atualiza uma empresa conforme a model passada pelo usuario
        /// Tem que existir no banco pois para encontrar é informado o id
        /// </summary>
        /// <param name="empresa"></param>
        public void AtualizarEmpresa(EmpresaModel empresa)
        {
            _context.Entry(empresa).State = EntityState.Modified;
        }

        /// <summary>
        /// Salva as alterações no banco de dados
        /// </summary>
        public void SalvarAlteracoes()
        {
            _context.SaveChanges();
        }
    }
}
