using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Producto
{
    public string? Descripcion { get; set; }

    public string? IdProducto { get; set; }

    public string? IdProducto1 { get; set; }

    public string? IdProducto2 { get; set; }

    public string? IdProducto3 { get; set; }

    public int? Cantidad { get; set; }

    public int? StockMinimo { get; set; }

    public decimal? PrecioCosto { get; set; }

    public decimal? PrecioVenta { get; set; }

    public decimal? PrecioVenta1 { get; set; }

    public decimal? PrecioVenta2 { get; set; }

    public decimal? PrecioVenta3 { get; set; }

    public int? IdRubro { get; set; }

    public int? IdMarca { get; set; }

    public int Id { get; set; }

    public int? Promocion { get; set; }

    public int? Compuesto { get; set; }

    public int? CantProm { get; set; }

    public decimal? PrecioProm { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public string? IvaEstado { get; set; }

    public decimal? IvaPorc { get; set; }

    public decimal? IvaImporte { get; set; }

    public decimal? PorcUtilidad1 { get; set; }

    public decimal? PorcUtilidad2 { get; set; }

    public decimal? PorcUtilidad3 { get; set; }

    public decimal? PorcUtilidad4 { get; set; }

    public decimal? ImporteUtilidad1 { get; set; }

    public decimal? ImporteUtilidad2 { get; set; }

    public decimal? ImporteUtilidad3 { get; set; }

    public decimal? ImporteUtilidad4 { get; set; }

    public int? Imprimible { get; set; }

    public int? IdMarcasWeb { get; set; }

    public int? StockReposicion { get; set; }

    public int? IdTalle { get; set; }

    public int? IdColor { get; set; }

    public int? Entero { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? TipoImpuesto { get; set; }

    public decimal? ValorImpuesto { get; set; }

    public int? UnidadMedida { get; set; }

    public decimal? PesoKilo { get; set; }

    public bool? ImpuestoAlimentos { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public int? IdProveedor { get; set; }

    public int? IdMoneda { get; set; }

    public decimal? PorcDescuento1 { get; set; }

    public decimal? PorcDescuento2 { get; set; }

    public decimal? PorcDescuento3 { get; set; }

    public decimal? ImpDescuento1 { get; set; }

    public decimal? ImpDescuento2 { get; set; }

    public decimal? ImpDescuento3 { get; set; }

    public decimal? Pbruto { get; set; }
}
