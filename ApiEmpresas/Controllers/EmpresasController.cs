using ApiEmpresas.Interfaces;
using ApiEmpresas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiEmpresas.Controllers
{
    /// <summary>
    /// Controller do cadastro de empresas
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        private readonly IEmpresasRepository _empresasRepository;

        public EmpresasController(IEmpresasRepository empresasRepository)
        {
            _empresasRepository = empresasRepository;
        }

        /// <summary>
        /// Cadastra novas empresas
        /// </summary>
        /// <param name="empresa"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddEmpresa([FromBody] EmpresaModel empresa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _empresasRepository.AdicionarEmpresa(empresa);
            _empresasRepository.SalvarAlteracoes();

            return Ok();
        }

        /// <summary>
        /// Deleta empresas conforme id informado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult DelEmpresa(int id)
        {
            _empresasRepository.ExcluirEmpresa(id);
            _empresasRepository.SalvarAlteracoes();

            return Ok();
        }

        /// <summary>
        /// Lista todas as empresas cadastradas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ListaTodasEmpresas()
        {
            var empresas = _empresasRepository.ListaEmpresas();

            return Ok(empresas);
        }

        /// <summary>
        /// Mostra uma empresa conforme id informado pelo usuário
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult ListaEmpresa(int id)
        {
            var empresa = _empresasRepository.EmpresaPorId(id);

            if(empresa == null)
            {
                return NotFound();
            }

            return Ok(empresa);
        }
        
        /// <summary>
        /// Atualiza empresa existente no banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <param name="empresa"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult AtualizaEmpresa(int id, [FromBody] EmpresaModel empresa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var empresaExistente = _empresasRepository.EmpresaPorId(id);

            if(empresaExistente == null)
            {
                return NotFound();
            }

            empresaExistente.Name = empresa.Name;
            empresaExistente.Descricao = empresa.Descricao;

            _empresasRepository.AtualizarEmpresa(empresaExistente);
            _empresasRepository.SalvarAlteracoes();

            return Ok();
        }        
    }
}
