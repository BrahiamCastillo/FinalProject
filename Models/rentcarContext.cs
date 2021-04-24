using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Models
{
    public partial class rentcarContext : DbContext
    {

        public rentcarContext(DbContextOptions<rentcarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alquileres> Alquileres { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Sangre> Sangre { get; set; }
        public virtual DbSet<TipoVehiculos> TipoVehiculos { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alquileres>(entity =>
            {
                entity.HasKey(e => new { e.IdAlquileres, e.ClientesIdClientes })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.HasIndex(e => e.ClientesIdClientes)
                    .HasName("fk_Alquileres_Clientes1_idx");

                entity.HasIndex(e => e.VehiculosIdVehiculos)
                    .HasName("fk_Alquileres_Vehiculos1_idx");

                entity.Property(e => e.IdAlquileres)
                    .HasColumnName("idAlquileres")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ClientesIdClientes).HasColumnName("Clientes_idClientes");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("date");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fecha_inicio")
                    .HasColumnType("date");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.Pagado).HasColumnName("pagado");

                entity.Property(e => e.VehiculosIdVehiculos).HasColumnName("Vehiculos_idVehiculos");

                entity.HasOne(d => d.ClientesIdClientesNavigation)
                    .WithMany(p => p.Alquileres)
                    .HasForeignKey(d => d.ClientesIdClientes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Alquileres_Clientes1");

                entity.HasOne(d => d.VehiculosIdVehiculosNavigation)
                    .WithMany(p => p.Alquileres)
                    .HasForeignKey(d => d.VehiculosIdVehiculos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Alquileres_Vehiculos1");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.IdClientes)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.SangreIdSangre)
                    .HasName("fk_Clientes_Sangre1_idx");

                entity.Property(e => e.IdClientes).HasColumnName("idClientes");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasColumnName("cedula")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasColumnName("correo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Licencia)
                    .IsRequired()
                    .HasColumnName("licencia")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Nacionalidad)
                    .IsRequired()
                    .HasColumnName("nacionalidad")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SangreIdSangre).HasColumnName("Sangre_idSangre");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.SangreIdSangreNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.SangreIdSangre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Clientes_Sangre1");
            });

            modelBuilder.Entity<Sangre>(entity =>
            {
                entity.HasKey(e => e.IdSangre)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdSangre).HasColumnName("idSangre");

                entity.Property(e => e.Sangre1)
                    .IsRequired()
                    .HasColumnName("Sangre")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TipoVehiculos>(entity =>
            {
                entity.HasKey(e => e.IdTipoVehiculos)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdTipoVehiculos).HasColumnName("idTipoVehiculos");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Vehiculos>(entity =>
            {
                entity.HasKey(e => e.IdVehiculos)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.TipoVehiculosIdTipoVehiculos)
                    .HasName("fk_Vehiculos_TipoVehiculos1_idx");

                entity.Property(e => e.IdVehiculos).HasColumnName("idVehiculos");

                entity.Property(e => e.Año)
                    .IsRequired()
                    .HasColumnName("año")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Capacidadcarga).HasColumnName("capacidadcarga");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Disponible)
                    .HasColumnName("disponible")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Nroseguro).HasColumnName("nroseguro");

                entity.Property(e => e.Pasajeros).HasColumnName("pasajeros");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TipoVehiculosIdTipoVehiculos).HasColumnName("TipoVehiculos_idTipoVehiculos");

                entity.HasOne(d => d.TipoVehiculosIdTipoVehiculosNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.TipoVehiculosIdTipoVehiculos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Vehiculos_TipoVehiculos1");
            });

            //Seeds Sangre

            modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                IdSangre = 1,
                Sangre1 = "O+",
            }
            );

            modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                IdSangre = 2,
                Sangre1 = "O-",
            }
            );

            modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                IdSangre = 3,
                Sangre1 = "A+",
            }
            );

            modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                IdSangre = 4,
                Sangre1 = "A-",
            }
            );

            modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                IdSangre = 5,
                Sangre1 = "B+",
            }
            );

            modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                IdSangre = 6,
                Sangre1 = "B-",
            }
            );

            modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                IdSangre = 7,
                Sangre1 = "AB+",
            }
            );

            modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                IdSangre = 8,
                Sangre1 = "AB-",
            }
            );

            //Seeds tipo de vehiculos

            modelBuilder.Entity<TipoVehiculos>().HasData(
                new TipoVehiculos
                {
                    IdTipoVehiculos = 1,
                    Tipo = "Carro",

                }
            );

            modelBuilder.Entity<TipoVehiculos>().HasData(
                new TipoVehiculos
                {
                    IdTipoVehiculos = 2,
                    Tipo = "Camioneta",

                }
            );

            modelBuilder.Entity<TipoVehiculos>().HasData(
                new TipoVehiculos
                {
                    IdTipoVehiculos = 3,
                    Tipo = "Jeep",

                }
            );

            modelBuilder.Entity<TipoVehiculos>().HasData(
                new TipoVehiculos
                {
                    IdTipoVehiculos = 4,
                    Tipo = "De lujo",

                }
            );

            modelBuilder.Entity<TipoVehiculos>().HasData(
                new TipoVehiculos
                {
                    IdTipoVehiculos = 5,
                    Tipo = "Nave espacial",

                }
            );

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
