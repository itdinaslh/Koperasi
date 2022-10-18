using Koperasi.Data;
using Koperasi.Domain.Entities;
using Koperasi.Domain.Repositories;

namespace Koperasi.Domain.Services;

public class WilayahService : IWilayah
{
    private readonly AppDbContext context;

    public WilayahService(AppDbContext context)
    {
        this.context = context;
    }

    public IQueryable<Provinsi> Provinsis => context.Provinsis;

    public IQueryable<Kabupaten> Kabupaten => context.Kabupatens;

    public IQueryable<Kecamatan> Kecamatans => context.Kecamatans;

    public IQueryable<Kelurahan> Kelurahans => context.Kelurahans;
}
