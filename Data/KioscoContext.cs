using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Productos.Models;

namespace Productos.Data;

public partial class KioscoContext : DbContext
{
    public KioscoContext()
    {
    }

    public KioscoContext(DbContextOptions<KioscoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Get the configuration object from the DI container
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange:
     true)
            .Build();

        // Extract the connection string from the configuration
        string connectionString = configuration.GetConnectionString("KioscoContext");


        // Use the connection string to configure DbContext
        optionsBuilder.UseSqlServer(connectionString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Productos2");

            entity.ToTable(tb => tb.HasTrigger("Aud_Productos"));

            entity.HasIndex(e => e.Descripcion, "index1");

            entity.HasIndex(e => e.IdProducto, "index2");

            entity.HasIndex(e => e.IdProducto1, "index3");

            entity.HasIndex(e => e.IdProducto2, "index4");

            entity.HasIndex(e => e.IdProducto3, "index5");

            entity.HasIndex(e => new { e.IdProducto, e.IdProducto1, e.IdProducto2, e.IdProducto3 }, "index6");

            entity.Property(e => e.Cantidad).HasDefaultValue(0);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(400)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CS_AI_KS_WS");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Modificacion");
            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.IdColor).HasColumnName("Id_Color");
            entity.Property(e => e.IdMarca).HasColumnName("Id_Marca");
            entity.Property(e => e.IdMarcasWeb).HasColumnName("Id_Marcas_Web");
            entity.Property(e => e.IdMoneda).HasColumnName("Id_Moneda");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Id_Producto");
            entity.Property(e => e.IdProducto1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Id_Producto1");
            entity.Property(e => e.IdProducto2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Id_Producto2");
            entity.Property(e => e.IdProducto3)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Id_Producto3");
            entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");
            entity.Property(e => e.IdRubro).HasColumnName("Id_Rubro");
            entity.Property(e => e.IdTalle).HasColumnName("Id_Talle");
            entity.Property(e => e.ImpDescuento1).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ImpDescuento2).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ImpDescuento3).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ImporteUtilidad1)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("Importe_Utilidad1");
            entity.Property(e => e.ImporteUtilidad2)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("Importe_Utilidad2");
            entity.Property(e => e.ImporteUtilidad3)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("Importe_Utilidad3");
            entity.Property(e => e.ImporteUtilidad4)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("Importe_Utilidad4");
            entity.Property(e => e.IvaEstado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Iva_Estado");
            entity.Property(e => e.IvaImporte)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("Iva_Importe");
            entity.Property(e => e.IvaPorc)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Iva_Porc");
            entity.Property(e => e.Pbruto)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("PBruto");
            entity.Property(e => e.PesoKilo).HasColumnType("decimal(15, 5)");
            entity.Property(e => e.PorcDescuento1).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PorcDescuento2).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PorcDescuento3).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PorcUtilidad1)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("Porc_Utilidad1");
            entity.Property(e => e.PorcUtilidad2)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("Porc_Utilidad2");
            entity.Property(e => e.PorcUtilidad3)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("Porc_Utilidad3");
            entity.Property(e => e.PorcUtilidad4)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("Porc_Utilidad4");
            entity.Property(e => e.PrecioCosto)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Precio_Costo");
            entity.Property(e => e.PrecioProm).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.PrecioVenta)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Precio_Venta");
            entity.Property(e => e.PrecioVenta1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Precio_Venta1");
            entity.Property(e => e.PrecioVenta2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Precio_Venta2");
            entity.Property(e => e.PrecioVenta3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Precio_Venta3");
            entity.Property(e => e.StockMinimo).HasDefaultValue(0);
            entity.Property(e => e.StockReposicion).HasColumnName("Stock_Reposicion");
            entity.Property(e => e.ValorImpuesto).HasColumnType("decimal(9, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
