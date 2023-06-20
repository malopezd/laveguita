using System;
using LaVeguita.API;
using LaVeguita.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaVeguita.API.Configs
{
    public class VentaDetalleConfig : IEntityTypeConfiguration<VentaDetalle>
    {
        public void Configure(EntityTypeBuilder<VentaDetalle> builder)
        {
            builder.ToTable("tb3VentasDetalles");
            builder.HasKey(c => new { c.id_producto, c.id_venta });

            builder
                .HasOne(detalle => detalle.Producto)
                .WithMany(producto => producto.VentaDetalles);

            builder
                .HasOne(detalle => detalle.Producto)
                .WithMany(venta => venta.VentaDetalles);
        }
    }
}

