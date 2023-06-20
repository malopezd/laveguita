using System;
using LaVeguita.API.Services.Implementation;
using LaVeguita.API.Services.Repositorio;
using LaVeguita.API.Services;
using LaVeguita.API.Models;

namespace LaVeguita.API.Services.Servicios
{
    public class ProductoServicio : IServicioBase<Producto, Guid>
    {
        private readonly IRepoBase<Producto, Guid> repoProducto;

        public ProductoServicio(IRepoBase<Producto, Guid> _repoProducto)
        {
            repoProducto = _repoProducto;
        }

        public Producto Agregar(Producto entidad)
        {
            if (entidad == null)
                throw new ArgumentNullException("El 'Producto' es requerido");

            var resultProducto = repoProducto.Agregar(entidad);
            repoProducto.GuardarCambios();
            return resultProducto;
        }

        public void Editar(Producto entidad)
        {
            if (entidad == null)
                throw new ArgumentNullException("El 'Producto' es requerido para editar");

            repoProducto.Editar(entidad);
            repoProducto.GuardarCambios();
        }

        public void Eliminar(Guid entidadId)
        {
            repoProducto.Eliminar(entidadId);
            repoProducto.GuardarCambios();
        }

        public List<Producto> Listar()
        {
            return repoProducto.Listar();
        }

        public Producto SeleccionarPorID(Guid entidadId)
        {
            return repoProducto.SeleccionarPorID(entidadId);
        }
    }
}

