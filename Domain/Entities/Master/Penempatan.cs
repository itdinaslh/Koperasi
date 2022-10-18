using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Koperasi.Domain.Entities;

[Table("Penempatan")]
public class Penempatan
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PenempatanId { get; set; }

#nullable disable

    [Required(ErrorMessage = "Nama penempatan wajib diisi")]
    [MaxLength(150)]
    public string NamaPenempatan { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
