using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperBanco.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Correcciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OperacionID",
                table: "Movimiento");

            migrationBuilder.RenameColumn(
                name: "MovimientoID",
                table: "Movimiento",
                newName: "MovimientoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cuentas",
                newName: "CuentaId");

            migrationBuilder.RenameColumn(
                name: "CajeroID",
                table: "Cajero",
                newName: "CajeroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovimientoId",
                table: "Movimiento",
                newName: "MovimientoID");

            migrationBuilder.RenameColumn(
                name: "CuentaId",
                table: "Cuentas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CajeroId",
                table: "Cajero",
                newName: "CajeroID");

            migrationBuilder.AddColumn<int>(
                name: "OperacionID",
                table: "Movimiento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
