using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Koperasi.Domain.Entities;

[Table("JenisBarang")]
public class JenisBarang
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int JenisBarangID { get; set; }

#nullable disable

    [Required]
    [MaxLength(50)]
    public string NamaJenis { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; } = DateTime.Now;

    public List<MerkBarang> MerkBarangs { get; set; }
}
