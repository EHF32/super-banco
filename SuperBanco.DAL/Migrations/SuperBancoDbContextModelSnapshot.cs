﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuperBanco.DAL;

#nullable disable

namespace SuperBanco.DAL.Migrations
{
    [DbContext(typeof(SuperBancoDbContext))]
    partial class SuperBancoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("SuperBanco.Model.Cajero", b =>
                {
                    b.Property<int>("CajeroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EsExterno")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CajeroId");

                    b.ToTable("Cajero");
                });

            modelBuilder.Entity("SuperBanco.Model.Cuenta", b =>
                {
                    b.Property<int>("CuentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IBAN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("TEXT");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CuentaId");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("SuperBanco.Model.Movimiento", b =>
                {
                    b.Property<int>("MovimientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CajeroID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Comision")
                        .HasColumnType("TEXT");

                    b.Property<string>("CuentaDestinoIBAN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CuentaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TarjetaID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovimientoId");

                    b.HasIndex("CajeroID");

                    b.HasIndex("CuentaId");

                    b.HasIndex("TarjetaID");

                    b.ToTable("Movimiento");
                });

            modelBuilder.Entity("SuperBanco.Model.Tarjeta", b =>
                {
                    b.Property<int>("TarjetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CVV")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CuentaId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EsActiva")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaExpiracion")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("LimiteCredito")
                        .HasColumnType("TEXT");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PIN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("TarjetaId");

                    b.HasIndex("CuentaId");

                    b.ToTable("Tarjeta");
                });

            modelBuilder.Entity("SuperBanco.Model.Movimiento", b =>
                {
                    b.HasOne("SuperBanco.Model.Cajero", "Cajero")
                        .WithMany("Movimientos")
                        .HasForeignKey("CajeroID");

                    b.HasOne("SuperBanco.Model.Cuenta", "Cuenta")
                        .WithMany("Movimientos")
                        .HasForeignKey("CuentaId");

                    b.HasOne("SuperBanco.Model.Tarjeta", "Tarjeta")
                        .WithMany("Movimientos")
                        .HasForeignKey("TarjetaID");

                    b.Navigation("Cajero");

                    b.Navigation("Cuenta");

                    b.Navigation("Tarjeta");
                });

            modelBuilder.Entity("SuperBanco.Model.Tarjeta", b =>
                {
                    b.HasOne("SuperBanco.Model.Cuenta", "Cuenta")
                        .WithMany("Tarjetas")
                        .HasForeignKey("CuentaId");

                    b.Navigation("Cuenta");
                });

            modelBuilder.Entity("SuperBanco.Model.Cajero", b =>
                {
                    b.Navigation("Movimientos");
                });

            modelBuilder.Entity("SuperBanco.Model.Cuenta", b =>
                {
                    b.Navigation("Movimientos");

                    b.Navigation("Tarjetas");
                });

            modelBuilder.Entity("SuperBanco.Model.Tarjeta", b =>
                {
                    b.Navigation("Movimientos");
                });
#pragma warning restore 612, 618
        }
    }
}
