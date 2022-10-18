using Koperasi.Domain.Entities;

namespace Koperasi.Domain.Repositories;

public interface ITugasTempat
{
    IQueryable<Penugasan> Penugasans { get; }
    IQueryable<Penempatan> Penempatans { get; }

    Task SavePenugasan(Penugasan penugasan);

    Task SavePenempatan(Penempatan penempatan);
}
