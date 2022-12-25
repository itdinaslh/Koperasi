using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Koperasi.Domain.Entities;

[Table("TipeBarang")]
public class TipeBarang
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TipeBarangID { get; set; }

#nullable disable

    [Required(ErrorMessage = "Nama Tipe Barang Wajib Diisi")]
    [MaxLength(150, ErrorMessage = "Maksimal 150 Karakter")]
    public string NamaTipe { get; set; }

    public int MerkBarangId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public MerkBarang MerkBarang { get; set; }
}
