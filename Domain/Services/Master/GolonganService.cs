using Koperasi.Data;
using Koperasi.Domain.Entities;
using Koperasi.Domain.Repositories;

namespace Koperasi.Domain.Services;

public class GolonganService : IGolongan
{
    private AppDbContext context;

    public GolonganService(AppDbContext context)
    {
        this.context = context;
    }

    public IQueryable<Golongan> Golongans => context.Golongans;

    public async Task SaveDataAsync(Golongan golongan)
    {
        if (golongan.GolonganId == 0)
        {
            await context.AddAsync(golongan);
        } else
        {
            Golongan? data = await context.Golongans.FindAsync(golongan.GolonganId);

            if (data is not null)
            {
                data.NamaGolongan = golongan.NamaGolongan;
                data.UpdatedAt = DateTime.Now;

                context.Update(data);
            }
        }

        await context.SaveChangesAsync();
    }
}
