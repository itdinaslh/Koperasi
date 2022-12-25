using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Koperasi.Domain.Entities;

[Table("Anggota")]
public class Anggota
{
    [Key]
    public Guid AnggotaID { get; set; }

#nullable disable

    [MaxLength(20)]
    public string KodeAnggota { get; set; }

    public int StatusAnggotaID { get; set; }

    [MaxLength(150)]
    public string NamaAnggota { get; set; }

#nullable enable

    [MaxLength(50)]    
    public string? TempatLahir { get; set; }
    
    public DateOnly TglLahir { get; set; }

    [MaxLength(30)]
    public string? NIP { get; set; }

#nullable disable

    [MaxLength(16)]
    [MinLength(16)]
    [Required]
    public string NIK { get; set; }

    [Required]
    [MaxLength(30)]
    public string NoRekening { get; set; }

#nullable enable

    [MaxLength(100)]
    public string? CabangBank { get; set; }


    [MaxLength(150)]
    public string? Keterangan { get; set; }

#nullable disable

    [Required]
    [MaxLength(150)]
    public string Alamat { get; set; }

    [MaxLength(15)]
    [Required]
    public string KelurahanID { get; set; }

    [Required]
    [MaxLength(20)]
    public string Telp { get; set; }

#nullable enable

    [MaxLength(10)]
    public string? KodePos { get; set; }
    
    public int? GolonganID { get; set; }

    public double? Gaji { get; set; }
    
    public int? PenugasanID { get; set; }
    
    public int? PenempatanID { get; set; }

    [MaxLength(150)]
    public string? NamaAtasan { get; set; }    

    public DateOnly? EndedDate { get; set; }

#nullable disable

    public DateOnly JoinedDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    public double SimpananPokok { get; set; }

    public double SimpananWajib { get; set; }

    public bool IsActive { get; set; } = true;
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public StatusAnggota StatusAnggota { get; set; }

    public Kelurahan Kelurahan { get; set; }

    public Golongan Golongan { get; set; }

    public Penugasan Penugasan { get; set; }

    public Penempatan Penempatan { get; set; }
}
