using System;
using LaVeguita.API.Services.Implementation;
using LaVeguita.API.Services;
using LaVeguita.API.Configs;
using LaVeguita.API.Models;


using Microsoft.EntityFrameworkCore;

namespace LaVeguita.API.DbContextos
{
	public class VentaContext : DbContext
	{
		public DbSet<Producto> Productos { get; set; }

        public DbSet<Venta> Ventas { get; set; }

        public DbSet<VentaDetalle> VentaDetalles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:laveguita2023server.database.windows.net,1433;Initial Catalog=LaVeguitaDB;Persist Security Info=False;User ID=LaVeguitaAdmin;Password=Abcd1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductoConfig());
            modelBuilder.ApplyConfiguration(new VentaConfig());
            modelBuilder.ApplyConfiguration(new VentaDetalleConfig());
        }

    }
}

 