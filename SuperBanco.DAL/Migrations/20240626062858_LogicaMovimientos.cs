using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperBanco.DAL.Migrations;

/// <inheritdoc />
public partial class LogicaMovimientos : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Estado",
            table: "Cuentas");

        migrationBuilder.DropColumn(
            name: "Tipo",
            table: "Cuentas");

        migrationBuilder.CreateTable(
            name: "Cajero",
            columns: table => new
            {
                CajeroID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Ubicacion = table.Column<string>(type: "TEXT", nullable: false),
                EsExterno = table.Column<bool>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Cajero", x => x.CajeroID);
            });

        migrationBuilder.CreateTable(
            name: "Tarjeta",
            columns: table => new
            {
                TarjetaId = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Numero = table.Column<string>(type: "TEXT", nullable: false),
                FechaExpiracion = table.Column<DateTime>(type: "TEXT", nullable: false),
                CVV = table.Column<int>(type: "INTEGER", nullable: false),
                Tipo = table.Column<int>(type: "INTEGER", nullable: false),
                LimiteCredito = table.Column<decimal>(type: "TEXT", nullable: false),
                EsActiva = table.Column<bool>(type: "INTEGER", nullable: false),
                PIN = table.Column<string>(type: "TEXT", nullable: false),
                CuentaId = table.Column<int>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Tarjeta", x => x.TarjetaId);
                table.ForeignKey(
                    name: "FK_Tarjeta_Cuentas_CuentaId",
                    column: x => x.CuentaId,
                    principalTable: "Cuentas",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateTable(
            name: "Movimiento",
            columns: table => new
            {
                MovimientoID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                OperacionID = table.Column<int>(type: "INTEGER", nullable: false),
                Tipo = table.Column<int>(type: "INTEGER", nullable: false),
                Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                Monto = table.Column<decimal>(type: "TEXT", nullable: false),
                Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                CuentaDestinoIBAN = table.Column<string>(type: "TEXT", nullable: false),
                Comision = table.Column<decimal>(type: "TEXT", nullable: true),
                TarjetaID = table.Column<int>(type: "INTEGER", nullable: true),
                CajeroID = table.Column<int>(type: "INTEGER", nullable: true),
                CuentaId = table.Column<int>(type: "INTEGER", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Movimiento", x => x.MovimientoID);
                table.ForeignKey(
                    name: "FK_Movimiento_Cajero_CajeroID",
                    column: x => x.CajeroID,
                    principalTable: "Cajero",
                    principalColumn: "CajeroID");
                table.ForeignKey(
                    name: "FK_Movimiento_Cuentas_CuentaId",
                    column: x => x.CuentaId,
                    principalTable: "Cuentas",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_Movimiento_Tarjeta_TarjetaID",
                    column: x => x.TarjetaID,
                    principalTable: "Tarjeta",
                    principalColumn: "TarjetaId");
            });

        migrationBuilder.CreateIndex(
            name: "IX_Movimiento_CajeroID",
            table: "Movimiento",
            column: "CajeroID");

        migrationBuilder.CreateIndex(
            name: "IX_Movimiento_CuentaId",
            table: "Movimiento",
            column: "CuentaId");

        migrationBuilder.CreateIndex(
            name: "IX_Movimiento_TarjetaID",
            table: "Movimiento",
            column: "TarjetaID");

        migrationBuilder.CreateIndex(
            name: "IX_Tarjeta_CuentaId",
            table: "Tarjeta",
            column: "CuentaId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Movimiento");

        migrationBuilder.DropTable(
            name: "Cajero");

        migrationBuilder.DropTable(
            name: "Tarjeta");

        migrationBuilder.AddColumn<string>(
            name: "Estado",
            table: "Cuentas",
            type: "TEXT",
            nullable: false,
            defaultValue: "");

        migrationBuilder.AddColumn<string>(
            name: "Tipo",
            table: "Cuentas",
            type: "TEXT",
            nullable: false,
            defaultValue: "");
    }
}
