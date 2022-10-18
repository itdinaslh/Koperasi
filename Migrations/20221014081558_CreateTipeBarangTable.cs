using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Koperasi.Migrations
{
    public partial class CreateTipeBarangTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Golongan",
                columns: table => new
                {
                    GolonganId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaGolongan = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Golongan", x => x.GolonganId);
                });

            migrationBuilder.CreateTable(
                name: "TipeBarang",
                columns: table => new
                {
                    TipeBarangId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaTipe = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    MerkBarangId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipeBarang", x => x.TipeBarangId);
                    table.ForeignKey(
                        name: "FK_TipeBarang_MerkBarang_MerkBarangId",
                        column: x => x.MerkBarangId,
                        principalTable: "MerkBarang",
                        principalColumn: "MerkBarangId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TipeBarang_MerkBarangId",
                table: "TipeBarang",
                column: "MerkBarangId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Golongan");

            migrationBuilder.DropTable(
                name: "TipeBarang");
        }
    }
}
