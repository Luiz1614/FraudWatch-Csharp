using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FraudWatch.Domain.Entities;

[Table("FW_Analistas")]
public class AnalistaEntity : UsuarioEntity
{
    [Required]
    [StringLength(100)]
    public string Departamento { get; set; }
}
