using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pureba_FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class ArreglosFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Marcas_Marca",
                table: "Modelos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marcas_MarcaId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Modelos_Marca",
                table: "Modelos");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Modelos");

            migrationBuilder.RenameColumn(
                name: "MarcaId",
                table: "Productos",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_MarcaId",
                table: "Productos",
                newName: "IX_Productos_CategoriaId");

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Modelos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_MarcaId",
                table: "Modelos",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Marcas_MarcaId",
                table: "Modelos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_CategoriaId",
                table: "Productos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Marcas_MarcaId",
                table: "Modelos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_CategoriaId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Modelos_MarcaId",
                table: "Modelos");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Modelos");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Productos",
                newName: "MarcaId");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_CategoriaId",
                table: "Productos",
                newName: "IX_Productos_MarcaId");

            migrationBuilder.AddColumn<int>(
                name: "Marca",
                table: "Modelos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_Marca",
                table: "Modelos",
                column: "Marca");

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Marcas_Marca",
                table: "Modelos",
                column: "Marca",
                principalTable: "Marcas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marcas_MarcaId",
                table: "Productos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
