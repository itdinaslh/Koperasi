using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koperasi.Migrations
{
    public partial class CreateAnggota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipeBarangId",
                table: "TipeBarang",
                newName: "TipeBarangID");

            migrationBuilder.RenameColumn(
                name: "StatusAnggotaId",
                table: "StatusAnggota",
                newName: "StatusAnggotaID");

            migrationBuilder.RenameColumn(
                name: "PenugasanId",
                table: "Penugasan",
                newName: "PenugasanID");

            migrationBuilder.RenameColumn(
                name: "PenempatanId",
                table: "Penempatan",
                newName: "PenempatanID");

            migrationBuilder.RenameColumn(
                name: "MerkBarangId",
                table: "MerkBarang",
                newName: "MerkBarangID");

            migrationBuilder.RenameColumn(
                name: "JenisBarangId",
                table: "JenisBarang",
                newName: "JenisBarangID");

            migrationBuilder.RenameColumn(
                name: "GolonganId",
                table: "Golongan",
                newName: "GolonganID");

            migrationBuilder.CreateTable(
                name: "Anggota",
                columns: table => new
                {
                    AnggotaID = table.Column<Guid>(type: "uuid", nullable: false),
                    KodeAnggota = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    StatusAnggotaID = table.Column<int>(type: "integer", nullable: false),
                    NamaAnggota = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    TempatLahir = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    TglLahir = table.Column<DateOnly>(type: "date", nullable: false),
                    NIP = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    NIK = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: false),
                    NoRekening = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    CabangBank = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Keterangan = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Alamat = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    KelurahanID = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Telp = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    KodePos = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    GolonganID = table.Column<int>(type: "integer", nullable: true),
                    Gaji = table.Column<double>(type: "double precision", nullable: true),
                    PenugasanID = table.Column<int>(type: "integer", nullable: true),
                    PenempatanID = table.Column<int>(type: "integer", nullable: true),
                    NamaAtasan = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    EndedDate = table.Column<DateOnly>(type: "date", nullable: true),
                    JoinedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SimpananPokok = table.Column<double>(type: "double precision", nullable: false),
                    SimpananWajib = table.Column<double>(type: "double precision", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anggota", x => x.AnggotaID);
                    table.ForeignKey(
                        name: "FK_Anggota_Golongan_GolonganID",
                        column: x => x.GolonganID,
                        principalTable: "Golongan",
                        principalColumn: "GolonganID");
                    table.ForeignKey(
                        name: "FK_Anggota_Kelurahan_KelurahanID",
                        column: x => x.KelurahanID,
                        principalTable: "Kelurahan",
                        principalColumn: "KelurahanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Anggota_Penempatan_PenempatanID",
                        column: x => x.PenempatanID,
                        principalTable: "Penempatan",
                        principalColumn: "PenempatanID");
                    table.ForeignKey(
                        name: "FK_Anggota_Penugasan_PenugasanID",
                        column: x => x.PenugasanID,
                        principalTable: "Penugasan",
                        principalColumn: "PenugasanID");
                    table.ForeignKey(
                        name: "FK_Anggota_StatusAnggota_StatusAnggotaID",
                        column: x => x.StatusAnggotaID,
                        principalTable: "StatusAnggota",
                        principalColumn: "StatusAnggotaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anggota_GolonganID",
                table: "Anggota",
                column: "GolonganID");

            migrationBuilder.CreateIndex(
                name: "IX_Anggota_KelurahanID",
                table: "Anggota",
                column: "KelurahanID");

            migrationBuilder.CreateIndex(
                name: "IX_Anggota_PenempatanID",
                table: "Anggota",
                column: "PenempatanID");

            migrationBuilder.CreateIndex(
                name: "IX_Anggota_PenugasanID",
                table: "Anggota",
                column: "PenugasanID");

            migrationBuilder.CreateIndex(
                name: "IX_Anggota_StatusAnggotaID",
                table: "Anggota",
                column: "StatusAnggotaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anggota");

            migrationBuilder.RenameColumn(
                name: "TipeBarangID",
                table: "TipeBarang",
                newName: "TipeBarangId");

            migrationBuilder.RenameColumn(
                name: "StatusAnggotaID",
                table: "StatusAnggota",
                newName: "StatusAnggotaId");

            migrationBuilder.RenameColumn(
                name: "PenugasanID",
                table: "Penugasan",
                newName: "PenugasanId");

            migrationBuilder.RenameColumn(
                name: "PenempatanID",
                table: "Penempatan",
                newName: "PenempatanId");

            migrationBuilder.RenameColumn(
                name: "MerkBarangID",
                table: "MerkBarang",
                newName: "MerkBarangId");

            migrationBuilder.RenameColumn(
                name: "JenisBarangID",
                table: "JenisBarang",
                newName: "JenisBarangId");

            migrationBuilder.RenameColumn(
                name: "GolonganID",
                table: "Golongan",
                newName: "GolonganId");
        }
    }
}
