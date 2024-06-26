using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperBanco.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AjustadoModelo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimiento_Cajero_CajeroID",
                table: "Movimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimiento_Cuentas_CuentaId",
                table: "Movimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimiento_Tarjeta_TarjetaID",
                table: "Movimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjeta_Cuentas_CuentaId",
                table: "Tarjeta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarjeta",
                table: "Tarjeta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movimiento",
                table: "Movimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cajero",
                table: "Cajero");

            migrationBuilder.RenameTable(
                name: "Tarjeta",
                newName: "Tarjetas");

            migrationBuilder.RenameTable(
                name: "Movimiento",
                newName: "Movimientos");

            migrationBuilder.RenameTable(
                name: "Cajero",
                newName: "Cajeros");

            migrationBuilder.RenameIndex(
                name: "IX_Tarjeta_CuentaId",
                table: "Tarjetas",
                newName: "IX_Tarjetas_CuentaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movimiento_TarjetaID",
                table: "Movimientos",
                newName: "IX_Movimientos_TarjetaID");

            migrationBuilder.RenameIndex(
                name: "IX_Movimiento_CuentaId",
                table: "Movimientos",
                newName: "IX_Movimientos_CuentaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movimiento_CajeroID",
                table: "Movimientos",
                newName: "IX_Movimientos_CajeroID");

            migrationBuilder.AddColumn<decimal>(
                name: "Comisiones",
                table: "Cajeros",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarjetas",
                table: "Tarjetas",
                column: "TarjetaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movimientos",
                table: "Movimientos",
                column: "MovimientoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cajeros",
                table: "Cajeros",
                column: "CajeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Cajeros_CajeroID",
                table: "Movimientos",
                column: "CajeroID",
                principalTable: "Cajeros",
                principalColumn: "CajeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Cuentas_CuentaId",
                table: "Movimientos",
                column: "CuentaId",
                principalTable: "Cuentas",
                principalColumn: "CuentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Tarjetas_TarjetaID",
                table: "Movimientos",
                column: "TarjetaID",
                principalTable: "Tarjetas",
                principalColumn: "TarjetaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjetas_Cuentas_CuentaId",
                table: "Tarjetas",
                column: "CuentaId",
                principalTable: "Cuentas",
                principalColumn: "CuentaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Cajeros_CajeroID",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Cuentas_CuentaId",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Tarjetas_TarjetaID",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjetas_Cuentas_CuentaId",
                table: "Tarjetas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarjetas",
                table: "Tarjetas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movimientos",
                table: "Movimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cajeros",
                table: "Cajeros");

            migrationBuilder.DropColumn(
                name: "Comisiones",
                table: "Cajeros");

            migrationBuilder.RenameTable(
                name: "Tarjetas",
                newName: "Tarjeta");

            migrationBuilder.RenameTable(
                name: "Movimientos",
                newName: "Movimiento");

            migrationBuilder.RenameTable(
                name: "Cajeros",
                newName: "Cajero");

            migrationBuilder.RenameIndex(
                name: "IX_Tarjetas_CuentaId",
                table: "Tarjeta",
                newName: "IX_Tarjeta_CuentaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movimientos_TarjetaID",
                table: "Movimiento",
                newName: "IX_Movimiento_TarjetaID");

            migrationBuilder.RenameIndex(
                name: "IX_Movimientos_CuentaId",
                table: "Movimiento",
                newName: "IX_Movimiento_CuentaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movimientos_CajeroID",
                table: "Movimiento",
                newName: "IX_Movimiento_CajeroID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarjeta",
                table: "Tarjeta",
                column: "TarjetaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movimiento",
                table: "Movimiento",
                column: "MovimientoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cajero",
                table: "Cajero",
                column: "CajeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimiento_Cajero_CajeroID",
                table: "Movimiento",
                column: "CajeroID",
                principalTable: "Cajero",
                principalColumn: "CajeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimiento_Cuentas_CuentaId",
                table: "Movimiento",
                column: "CuentaId",
                principalTable: "Cuentas",
                principalColumn: "CuentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimiento_Tarjeta_TarjetaID",
                table: "Movimiento",
                column: "TarjetaID",
                principalTable: "Tarjeta",
                principalColumn: "TarjetaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjeta_Cuentas_CuentaId",
                table: "Tarjeta",
                column: "CuentaId",
                principalTable: "Cuentas",
                principalColumn: "CuentaId");
        }
    }
}
