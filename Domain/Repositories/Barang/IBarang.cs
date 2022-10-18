using Koperasi.Domain.Entities;

namespace Koperasi.Domain.Repositories;

public interface IBarang
{
    IQueryable<JenisBarang> JenisBarangs { get; }

    IQueryable<MerkBarang> MerkBarangs { get; }

    Task SaveJenisBarang(JenisBarang jenis);

    Task SaveMerkBarang(MerkBarang merk);
}
