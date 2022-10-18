using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koperasi.Migrations
{
    public partial class RenameTableMerkAndJenis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MerkBarangs_JenisBarangs_JenisBarangId",
                table: "MerkBarangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MerkBarangs",
                table: "MerkBarangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JenisBarangs",
                table: "JenisBarangs");

            migrationBuilder.RenameTable(
                name: "MerkBarangs",
                newName: "MerkBarang");

            migrationBuilder.RenameTable(
                name: "JenisBarangs",
                newName: "JenisBarang");

            migrationBuilder.RenameIndex(
                name: "IX_MerkBarangs_JenisBarangId",
                table: "MerkBarang",
                newName: "IX_MerkBarang_JenisBarangId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MerkBarang",
                table: "MerkBarang",
                column: "MerkBarangId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JenisBarang",
                table: "JenisBarang",
                column: "JenisBarangId");

            migrationBuilder.AddForeignKey(
                name: "FK_MerkBarang_JenisBarang_JenisBarangId",
                table: "MerkBarang",
                column: "JenisBarangId",
                principalTable: "JenisBarang",
                principalColumn: "JenisBarangId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MerkBarang_JenisBarang_JenisBarangId",
                table: "MerkBarang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MerkBarang",
                table: "MerkBarang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JenisBarang",
                table: "JenisBarang");

            migrationBuilder.RenameTable(
                name: "MerkBarang",
                newName: "MerkBarangs");

            migrationBuilder.RenameTable(
                name: "JenisBarang",
                newName: "JenisBarangs");

            migrationBuilder.RenameIndex(
                name: "IX_MerkBarang_JenisBarangId",
                table: "MerkBarangs",
                newName: "IX_MerkBarangs_JenisBarangId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MerkBarangs",
                table: "MerkBarangs",
                column: "MerkBarangId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JenisBarangs",
                table: "JenisBarangs",
                column: "JenisBarangId");

            migrationBuilder.AddForeignKey(
                name: "FK_MerkBarangs_JenisBarangs_JenisBarangId",
                table: "MerkBarangs",
                column: "JenisBarangId",
                principalTable: "JenisBarangs",
                principalColumn: "JenisBarangId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
