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
    public class ProductoRepositorio : IRepoBase<Producto, Guid>
    {
        private VentaContext db;

        public ProductoRepositorio(VentaContext _db )
        {
            db = _db; 
        }

        public Producto Agregar(Producto entidad)
        {
            entidad.id_producto = Guid.NewGuid();
            db.Productos.Add(entidad);
            return entidad;
        }

        public void Editar(Producto entidad)
        {
            var productoSeleccionado = db.Productos.Where(c => c.id_producto == entidad.id_producto).FirstOrDefault();
            if(productoSeleccionado != null)
            {
                productoSeleccionado.nombre_producto = entidad.nombre_producto;
                productoSeleccionado.descripcion_producto = entidad.descripcion_producto;
                productoSeleccionado.costo_producto = entidad.costo_producto;
                productoSeleccionado.precio_producto = entidad.precio_producto;
                productoSeleccionado.stock_producto = entidad.stock_producto;

                db.Entry(productoSeleccionado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(Guid entidadId)
        {
            var productoSeleccionado = db.Productos.Where(c => c.id_producto == entidadId).FirstOrDefault();
            if (productoSeleccionado != null)
            {
                db.Productos.Remove(productoSeleccionado );
            }
        }


        public void GuardarCambios()
        {
            db.SaveChanges();
        }

        public List<Producto> Listar()
        {
            return db.Productos.ToList();
        }

        public Producto SeleccionarPorID(Guid entidadId)
        {
            var productoSeleccionado = db.Productos.Where(c => c.id_producto == entidadId).FirstOrDefault();
            return productoSeleccionado;
        }
    }
}

