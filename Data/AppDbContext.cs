using Koperasi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Koperasi.Data;

public class AppDbContext : DbContext
{
    #nullable disable

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Master wilayah
    public DbSet<Provinsi> Provinsis { get; set; }
    public DbSet<Kabupaten> Kabupatens { get; set; }
    public DbSet<Kecamatan> Kecamatans { get; set; }
    public DbSet<Kelurahan> Kelurahans { get; set; }

    // Master Value
    public DbSet<Penugasan> Penugasans { get; set; }
    public DbSet<Penempatan> Penempatans { get; set; }
    public DbSet<StatusAnggota> Statuses { get; set; }
    public DbSet<Golongan> Golongans { get; set; }

    // Barang
    public DbSet<JenisBarang> JenisBarangs { get; set; }
    public DbSet<MerkBarang> MerkBarangs { get; set; }
    public DbSet<TipeBarang> TipeBarangs { get; set; }

    // Keanggotaan
    public DbSet<Anggota> Anggota { get; set; }
}
