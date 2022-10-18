﻿using Koperasi.Data;
using Koperasi.Domain.Entities;
using Koperasi.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Koperasi.Domain.Services;

public class TugasTempatService : ITugasTempat
{
    private readonly AppDbContext context;

    public TugasTempatService(AppDbContext context)
    {
        this.context = context;
    }

    public IQueryable<Penugasan> Penugasans => context.Penugasans;

    public IQueryable<Penempatan> Penempatans => context.Penempatans;

    public async Task SavePenempatan(Penempatan penempatan)
    {
        if (penempatan.PenempatanId == 0)
        {
            await context.AddAsync(penempatan);
        } else
        {
            Penempatan? data = await context.Penempatans.FindAsync(penempatan.PenempatanId);

            if (data is not null)
            {
                data.NamaPenempatan = penempatan.NamaPenempatan;
                data.UpdatedAt = DateTime.Now;

                context.Update(data);
            }
        }

        await context.SaveChangesAsync();
    }

    public async Task SavePenugasan(Penugasan penugasan)
    {
        if (penugasan.PenugasanId == 0)
        {
            await context.AddAsync(penugasan);
        } else
        {
            Penugasan? data = await context.Penugasans.FirstOrDefaultAsync(p => p.PenugasanId == penugasan.PenugasanId);

            if (data is not null)
            {
                data.NamaPenugasan = penugasan.NamaPenugasan;
                data.UpdatedAt = DateTime.Now;

                context.Update(data);
            }
        }

        await context.SaveChangesAsync();
    }
}
