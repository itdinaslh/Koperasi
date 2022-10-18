using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Koperasi.Domain.Entities;

[Table("StatusAnggota")]
public class StatusAnggota
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StatusAnggotaId { get; set; }

#nullable disable

    [Required(ErrorMessage = "Nama Status Anggota Wajib Diisi")]
    public string NamaStatus { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; } = DateTime.Now;

}
