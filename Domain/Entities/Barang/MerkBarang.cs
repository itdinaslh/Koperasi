using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Koperasi.Domain.Entities;

[Table("MerkBarang")]
public class MerkBarang
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MerkBarangID { get; set; }

#nullable disable

    [Required(ErrorMessage = "Nama Barang Wajib Diisi")]
    [MaxLength(100)]
    public string NamaMerk { get; set; }

    public int JenisBarangId { get; set; }

    public JenisBarang JenisBarang{ get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; } = DateTime.Now;

    public List<TipeBarang> TipeBarangs { get; set; }
}
