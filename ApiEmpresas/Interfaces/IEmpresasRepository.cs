using ApiEmpresas.Models;

namespace ApiEmpresas.Interfaces
{
    /// <summary>
    /// Interface de Empresa Repository
    /// </summary>
    public interface IEmpresasRepository
    {
        void AdicionarEmpresa(EmpresaModel empresa);
        void ExcluirEmpresa(int id);
        List<EmpresaModel> ListaEmpresas();
        EmpresaModel EmpresaPorId(int id);
        void AtualizarEmpresa(EmpresaModel empresa);

        void SalvarAlteracoes();
    }
}
