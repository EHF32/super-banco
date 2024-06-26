using Microsoft.EntityFrameworkCore;
using SuperBanco.DAL;

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


}
