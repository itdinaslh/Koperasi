using Koperasi.Domain.Entities;

namespace Koperasi.Domain.Repositories;

public interface IGolongan
{
    IQueryable<Golongan> Golongans { get; }

    Task SaveDataAsync(Golongan golongan);
}
