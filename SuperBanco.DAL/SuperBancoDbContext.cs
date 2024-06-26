using Microsoft.EntityFrameworkCore;
using SuperBanco.Model;

namespace SuperBanco.DAL;


public class SuperBancoDbContext : DbContext
{
    public DbSet<Cuenta> Cuentas { get; set; }

    public string DbPath { get; }

    public SuperBancoDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "superbanco.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cuenta>()
            .HasMany(c => c.Movimientos)
            .WithOne(o => o.Cuenta)
            .HasForeignKey(o => o.CuentaId)
            .IsRequired(false);

        modelBuilder.Entity<Tarjeta>()
            .HasMany(t => t.Movimientos)
            .WithOne(o => o.Tarjeta)
            .HasForeignKey(o => o.TarjetaID)
            .IsRequired(false);

        modelBuilder.Entity<Cajero>()
            .HasMany(c => c.Movimientos)
            .WithOne(o => o.Cajero)
            .HasForeignKey(o => o.CajeroID)
            .IsRequired(false);

        modelBuilder.Entity<Cuenta>()
            .HasMany(c => c.Tarjetas)
            .WithOne(t => t.Cuenta)
            .HasForeignKey(t => t.CuentaId)
            .IsRequired(false);

    } 
}
