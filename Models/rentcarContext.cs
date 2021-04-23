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

                entity.Property(e => e.Fotolicencia)
                    .IsRequired()
                    .HasColumnName("fotolicencia")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Fotopersona)
                    .IsRequired()
                    .HasColumnName("fotopersona")
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

                entity.Property(e => e.Tipodesangre)
                    .IsRequired()
                    .HasColumnName("tipodesangre")
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

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasColumnName("foto")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

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

                entity.Property(e => e.TipoVehiculosIdTipoVehiculos).HasColumnName("TipoVehiculos_idTipoVehiculos");

                entity.HasOne(d => d.TipoVehiculosIdTipoVehiculosNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.TipoVehiculosIdTipoVehiculos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Vehiculos_TipoVehiculos1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
