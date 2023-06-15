using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiEmpresas.Migrations
{
    /// <inheritdoc />
    public partial class AjustaNomeTabelaEmpresas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmpresasModel",
                table: "EmpresasModel");

            migrationBuilder.RenameTable(
                name: "EmpresasModel",
                newName: "Empresas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas");

            migrationBuilder.RenameTable(
                name: "Empresas",
                newName: "EmpresasModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmpresasModel",
                table: "EmpresasModel",
                column: "Id");
        }
    }
}
