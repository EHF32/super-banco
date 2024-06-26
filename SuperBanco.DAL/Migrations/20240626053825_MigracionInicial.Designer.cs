﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuperBanco.DAL;

#nullable disable

namespace SuperBanco.DAL.Migrations;

[DbContext(typeof(SuperBancoDbContext))]
[Migration("20240626053825_MigracionInicial")]
partial class MigracionInicial
{
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

        modelBuilder.Entity("SuperBanco.DAL.Cuenta", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Estado")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("IBAN")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<decimal>("Saldo")
                    .HasColumnType("TEXT");

                b.Property<string>("Tipo")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("UsuarioId")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Cuentas");
            });
#pragma warning restore 612, 618
    }
}
