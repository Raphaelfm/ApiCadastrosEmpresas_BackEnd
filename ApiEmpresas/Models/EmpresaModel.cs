using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEmpresas.Models
{
    [Table("Empresas")]
    public class EmpresaModel
    {
        [Key]
        public int Id { get; set; }

        [Column("Nome")]
        public string? Nome { get; set; }

        [Column("Descricao")]
        public string? Descricao { get; set; }
    }
}
