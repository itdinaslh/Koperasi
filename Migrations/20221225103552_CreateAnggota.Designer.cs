// <auto-generated />
using System;
using Koperasi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Koperasi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221225103552_CreateAnggota")]
    partial class CreateAnggota
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Koperasi.Domain.Entities.Anggota", b =>
                {
                    b.Property<Guid>("AnggotaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("CabangBank")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly?>("EndedDate")
                        .HasColumnType("date");

                    b.Property<double?>("Gaji")
                        .HasColumnType("double precision");

                    b.Property<int?>("GolonganID")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateOnly>("JoinedDate")
                        .HasColumnType("date");

                    b.Property<string>("KelurahanID")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("Keterangan")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("KodeAnggota")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("KodePos")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("NIK")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("NIP")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("NamaAnggota")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("NamaAtasan")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("NoRekening")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int?>("PenempatanID")
                        .HasColumnType("integer");

                    b.Property<int?>("PenugasanID")
                        .HasColumnType("integer");

                    b.Property<double>("SimpananPokok")
                        .HasColumnType("double precision");

                    b.Property<double>("SimpananWajib")
                        .HasColumnType("double precision");

                    b.Property<int>("StatusAnggotaID")
                        .HasColumnType("integer");

                    b.Property<string>("Telp")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("TempatLahir")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateOnly>("TglLahir")
                        .HasColumnType("date");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("AnggotaID");

                    b.HasIndex("GolonganID");

                    b.HasIndex("KelurahanID");

                    b.HasIndex("PenempatanID");

                    b.HasIndex("PenugasanID");

                    b.HasIndex("StatusAnggotaID");

                    b.ToTable("Anggota");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.Golongan", b =>
                {
                    b.Property<int>("GolonganID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GolonganID"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NamaGolongan")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("GolonganID");

                    b.ToTable("Golongan");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.JenisBarang", b =>
                {
                    b.Property<int>("JenisBarangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("JenisBarangID"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NamaJenis")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("JenisBarangID");

                    b.ToTable("JenisBarang");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.Kabupaten", b =>
                {
                    b.Property<string>("KabupatenID")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<bool>("IsKota")
                        .HasColumnType("boolean");

                    b.Property<string>("Latitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("NamaKabupaten")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("ProvinsiID")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.HasKey("KabupatenID");

                    b.HasIndex("ProvinsiID");

                    b.ToTable("Kabupaten");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.Kecamatan", b =>
                {
                    b.Property<string>("KecamatanID")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("KabupatenID")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("NamaKecamatan")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("KecamatanID");

                    b.HasIndex("KabupatenID");

                    b.ToTable("Kecamatan");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.Kelurahan", b =>
                {
                    b.Property<string>("KelurahanID")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("KecamatanID")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("NamaKelurahan")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("KelurahanID");

                    b.HasIndex("KecamatanID");

                    b.ToTable("Kelurahan");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.MerkBarang", b =>
                {
                    b.Property<int>("MerkBarangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MerkBarangID"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("JenisBarangId")
                        .HasColumnType("integer");

                    b.Property<string>("NamaMerk")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("MerkBarangID");

                    b.HasIndex("JenisBarangId");

                    b.ToTable("MerkBarang");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.Penempatan", b =>
                {
                    b.Property<int>("PenempatanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PenempatanID"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NamaPenempatan")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("PenempatanID");

                    b.ToTable("Penempatan");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.Penugasan", b =>
                {
                    b.Property<int>("PenugasanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PenugasanID"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NamaPenugasan")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Pimpinan")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("PenugasanID");

                    b.ToTable("Penugasan");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.Provinsi", b =>
                {
                    b.Property<string>("ProvinsiID")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<string>("HcKey")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("KodeNegara")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("NamaProvinsi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("ProvinsiID");

                    b.ToTable("Provinsi");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.StatusAnggota", b =>
                {
                    b.Property<int>("StatusAnggotaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StatusAnggotaID"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NamaStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("StatusAnggotaID");

                    b.ToTable("StatusAnggota");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.TipeBarang", b =>
                {
                    b.Property<int>("TipeBarangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TipeBarangID"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MerkBarangId")
                        .HasColumnType("integer");

                    b.Property<string>("NamaTipe")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("TipeBarangID");

                    b.HasIndex("MerkBarangId");

                    b.ToTable("TipeBarang");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.Anggota", b =>
                {
                    b.HasOne("Koperasi.Domain.Entities.Golongan", "Golongan")
                        .WithMany()
                        .HasForeignKey("GolonganID");

                    b.HasOne("Koperasi.Domain.Entities.Kelurahan", "Kelurahan")
                        .WithMany()
                        .HasForeignKey("KelurahanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Koperasi.Domain.Entities.Penempatan", "Penempatan")
                        .WithMany()
                        .HasForeignKey("PenempatanID");

                    b.HasOne("Koperasi.Domain.Entities.Penugasan", "Penugasan")
                        .WithMany()
                        .HasForeignKey("PenugasanID");

                    b.HasOne("Koperasi.Domain.Entities.StatusAnggota", "StatusAnggota")
                        .WithMany()
                        .HasForeignKey("StatusAnggotaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Golongan");

                    b.Navigation("Kelurahan");

                    b.Navigation("Penempatan");

                    b.Navigation("Penugasan");

                    b.Navigation("StatusAnggota");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.Kabupaten", b =>
                {
                    b.HasOne("Koperasi.Domain.Entities.Provinsi", "Provinsi")
                        .WithMany("Kabupatens")
                        .HasForeignKey("ProvinsiID");

                    b.Navigation("Provinsi");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.Kecamatan", b =>
                {
                    b.HasOne("Koperasi.Domain.Entities.Kabupaten", "Kabupaten")
                        .WithMany("Kecamatans")
                        .HasForeignKey("KabupatenID");

                    b.Navigation("Kabupaten");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.Kelurahan", b =>
                {
                    b.HasOne("Koperasi.Domain.Entities.Kecamatan", "Kecamatan")
                        .WithMany("Kelurahans")
                        .HasForeignKey("KecamatanID");

                    b.Navigation("Kecamatan");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.MerkBarang", b =>
                {
                    b.HasOne("Koperasi.Domain.Entities.JenisBarang", "JenisBarang")
                        .WithMany("MerkBarangs")
                        .HasForeignKey("JenisBarangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JenisBarang");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.TipeBarang", b =>
                {
                    b.HasOne("Koperasi.Domain.Entities.MerkBarang", "MerkBarang")
                        .WithMany("TipeBarangs")
                        .HasForeignKey("MerkBarangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MerkBarang");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.JenisBarang", b =>
                {
                    b.Navigation("MerkBarangs");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.Kabupaten", b =>
                {
                    b.Navigation("Kecamatans");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.Kecamatan", b =>
                {
                    b.Navigation("Kelurahans");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.MerkBarang", b =>
                {
                    b.Navigation("TipeBarangs");
                });

            modelBuilder.Entity("Koperasi.Domain.Entities.Provinsi", b =>
                {
                    b.Navigation("Kabupatens");
                });
#pragma warning restore 612, 618
        }
    }
}
