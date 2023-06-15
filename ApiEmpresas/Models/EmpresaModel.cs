using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEmpresas.Models
{
    [Table("Empresas")]
    public class EmpresaModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Descricao { get; set; }
    }
}
