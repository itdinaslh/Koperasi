using Koperasi.Domain.Entities;

namespace Koperasi.Domain.Repositories;

public interface IWilayah
{
    IQueryable<Provinsi> Provinsis { get; }
    IQueryable<Kabupaten> Kabupaten { get; }
    IQueryable<Kecamatan> Kecamatans { get; }
    IQueryable<Kelurahan> Kelurahans { get; }
}
