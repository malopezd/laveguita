using System;
using LaVeguita.API;
using LaVeguita.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaVeguita.API.Configs
{
    public class ProductoConfig : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("tb1Productos");
            builder.HasKey(c => c.id_producto);

            builder
                .HasMany(producto => producto.VentaDetalles)
                .WithOne(detalle => detalle.Producto);
        }
    }
}

