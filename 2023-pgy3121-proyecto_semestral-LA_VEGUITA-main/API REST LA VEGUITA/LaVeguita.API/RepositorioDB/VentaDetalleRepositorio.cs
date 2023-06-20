using LaVeguita.API.Models;
using LaVeguita.API.Services;
using LaVeguita.API.Configs;
using LaVeguita.API.Services.Implementation;
using LaVeguita.API.Services.Repositorio;
using LaVeguita.API.Services.Servicios;
using LaVeguita.API.DbContextos;
using System.Linq;
using System;


namespace LaVeguita.API.RepositorioDB
{
    public class VentaDetalleRepositorio : IRepoDetalleVenta<VentaDetalle, Guid>
    {

        private VentaContext db;

        public VentaDetalleRepositorio(VentaContext _db)
        {
            db = _db;
        }

        public VentaDetalle Agregar(VentaDetalle entidad)
        {
            db.VentaDetalles.Add(entidad);
            return entidad;
        }

        public void GuardarCambios()
        {
            db.SaveChanges();
        }
    }
}

