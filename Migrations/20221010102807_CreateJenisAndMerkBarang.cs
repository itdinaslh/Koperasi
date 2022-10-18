using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Koperasi.Migrations
{
    public partial class CreateJenisAndMerkBarang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JenisBarangs",
                columns: table => new
                {
                    JenisBarangId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaJenis = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JenisBarangs", x => x.JenisBarangId);
                });

            migrationBuilder.CreateTable(
                name: "MerkBarangs",
                columns: table => new
                {
                    MerkBarangId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaMerk = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    JenisBarangId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerkBarangs", x => x.MerkBarangId);
                    table.ForeignKey(
                        name: "FK_MerkBarangs_JenisBarangs_JenisBarangId",
                        column: x => x.JenisBarangId,
                        principalTable: "JenisBarangs",
                        principalColumn: "JenisBarangId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MerkBarangs_JenisBarangId",
                table: "MerkBarangs",
                column: "JenisBarangId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MerkBarangs");

            migrationBuilder.DropTable(
                name: "JenisBarangs");
        }
    }
}
