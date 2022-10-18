using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Koperasi.Domain.Entities;

[Table("Penugasan")]
public class Penugasan
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PenugasanId { get; set; }

#nullable disable
    [Required(ErrorMessage = "Nama tempat penugasan wajib diisi!")]
    [MaxLength(100)]
    public string NamaPenugasan { get; set; }

#nullable enable

    [MaxLength(100)]
    public string? Pimpinan { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; } = DateTime.Now;
}
