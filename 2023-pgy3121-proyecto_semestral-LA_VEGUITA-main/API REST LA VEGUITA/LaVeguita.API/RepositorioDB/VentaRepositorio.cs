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
    public class VentaRepositorio : IRepoVenta<Venta, Guid>
    {
        private VentaContext db;

        public VentaRepositorio(VentaContext _db)
        {
            db = _db;
        }



        public Venta Agregar(Venta entidad)
        {
            entidad.id_venta = Guid.NewGuid();
            db.Ventas.Add(entidad);
            return entidad;
        }

        public void Anular(Guid entidadId)
        {
            var ventaSeleccionada = db.Ventas.Where(c => c.id_venta == entidadId)
.FirstOrDefault();
            if (ventaSeleccionada == null)
                throw new NullReferenceException("Esta intentando anular una venta que no existe");

            ventaSeleccionada.anulado = true;
            db.Entry(ventaSeleccionada).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

        }

        public void GuardarCambios()
        {
            db.SaveChanges();
        }

        public List<Venta> Listar()
        {
            return db.Ventas.ToList();
        }

        public Venta SeleccionarPorID(Guid entidadId)
        {
            var ventaSeleccionada = db.Ventas.Where(c => c.id_venta == entidadId).FirstOrDefault();
            return ventaSeleccionada;
        }
    }
}

