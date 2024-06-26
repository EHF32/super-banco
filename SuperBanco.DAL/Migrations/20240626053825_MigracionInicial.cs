using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperBanco.DAL.Migrations;

/// <inheritdoc />
public partial class MigracionInicial : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Cuentas",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                UsuarioId = table.Column<string>(type: "TEXT", nullable: false),
                IBAN = table.Column<string>(type: "TEXT", nullable: false),
                Saldo = table.Column<decimal>(type: "TEXT", nullable: false),
                Tipo = table.Column<string>(type: "TEXT", nullable: false),
                Estado = table.Column<string>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Cuentas", x => x.Id);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Cuentas");
    }
}
