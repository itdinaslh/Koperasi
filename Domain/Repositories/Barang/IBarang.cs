using Koperasi.Domain.Entities;

namespace Koperasi.Domain.Repositories;

public interface IBarang
{
    IQueryable<JenisBarang> JenisBarangs { get; }

    IQueryable<MerkBarang> MerkBarangs { get; }

    IQueryable<TipeBarang> TipeBarangs { get; }

    Task SaveJenisBarang(JenisBarang jenis);

    Task SaveMerkBarang(MerkBarang merk);

    Task SaveTipeBarang(TipeBarang tipe);
}
