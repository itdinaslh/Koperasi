using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Koperasi.Domain.Entities;

[Table("Golongan")]
public class Golongan
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GolonganID { get; set; }

#nullable disable

    public string NamaGolongan { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
