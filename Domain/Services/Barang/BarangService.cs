using Koperasi.Data;
using Koperasi.Domain.Entities;
using Koperasi.Domain.Repositories;

namespace Koperasi.Domain.Services;

public class BarangService : IBarang
{
    private readonly AppDbContext context;

    public BarangService(AppDbContext context)
    {
        this.context = context;
    }

    public IQueryable<JenisBarang> JenisBarangs => context.JenisBarangs;

    public IQueryable<MerkBarang> MerkBarangs => context.MerkBarangs;

    public async Task SaveJenisBarang(JenisBarang jenis)
    {
        if (jenis.JenisBarangID == 0)
        {
            await context.AddAsync(jenis);
        } else
        {
            JenisBarang? data = await context.JenisBarangs.FindAsync(jenis.JenisBarangID);

            if (data is not null)
            {
                data.NamaJenis = jenis.NamaJenis;
                data.UpdatedAt = DateTime.Now;

                context.Update(data);
            }
        }

        await context.SaveChangesAsync();
    }

    public async Task SaveMerkBarang(MerkBarang merk)
    {
        if (merk.MerkBarangID == 0)
        {
            await context.AddAsync(merk);
        }
        else
        {
            MerkBarang? data = await context.MerkBarangs.FindAsync(merk.MerkBarangID);

            if (data is not null)
            {
                data.NamaMerk = merk.NamaMerk;
                data.JenisBarangId = merk.JenisBarangId;
                data.UpdatedAt = DateTime.Now;

                context.Update(data);
            }
        }

        await context.SaveChangesAsync();
    }
}
