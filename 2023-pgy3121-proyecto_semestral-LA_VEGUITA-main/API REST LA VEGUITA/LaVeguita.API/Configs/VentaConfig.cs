using System;
using LaVeguita.API;
using LaVeguita.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaVeguita.API.Configs
{
    public class VentaConfig : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("tb2Ventas");
            builder.HasKey(c => c.id_venta);

            builder
                .HasMany(venta => venta.VentaDetalles)
                .WithOne(detalle => detalle.Venta);
        }
    }
}

