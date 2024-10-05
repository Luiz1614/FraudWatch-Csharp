using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FraudWatch.Domain.Entities;

[Table("Dentistas")]
public class DentistaEntity : UsuarioEntity
{
    [Required]
    [StringLength(20)]
    public string CRO { get; set; }
}
