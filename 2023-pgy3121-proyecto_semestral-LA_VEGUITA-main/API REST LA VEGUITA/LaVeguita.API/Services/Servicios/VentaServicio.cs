using System;
using LaVeguita.API.Services.Implementation;
using LaVeguita.API.Services.Repositorio;
using LaVeguita.API.Services;
using LaVeguita.API.Models;

namespace LaVeguita.API.Services.Servicios
{
    public class VentaServicio : IServicioVenta<Venta, Guid>
    {
        IRepoVenta<Venta, Guid> repoVenta;
        IRepoBase<Producto, Guid> repoProducto;
        IRepoDetalleVenta<VentaDetalle, Guid> repoDetalle;

        public VentaServicio(
            IRepoVenta<Venta, Guid> _repoVenta,
            IRepoBase<Producto, Guid> _repoProducto,
            IRepoDetalleVenta<VentaDetalle, Guid> _repoDetalle
            )
        {
            repoVenta = _repoVenta;
            repoProducto = _repoProducto;
            repoDetalle = _repoDetalle;
        }

        public Venta Agregar(Venta entidad)
        {
            if (entidad == null)
                throw new ArgumentNullException("La 'Venta' es requerida");

            var VentaAgregada = repoVenta.Agregar(entidad);

            entidad.VentaDetalles.ForEach(detalle =>
            {
                var productoSeleccionado = repoProducto.SeleccionarPorID(detalle.id_producto);
                if (productoSeleccionado == null)
                    throw new NullReferenceException("Esta intentando agregar un producto que no existe");

                 
                detalle.costo_unitario = productoSeleccionado.costo_producto;
                detalle.cantidad_unitario = detalle.cantidad_unitario;
                detalle.subtotal_detalleventa = detalle.precio_unitario * detalle.cantidad_unitario;
                detalle.impuesto_detalleventa = detalle.subtotal_detalleventa * 19 / 100;
                detalle.subtotal_detalleventa = detalle.subtotal_detalleventa + detalle.impuesto_detalleventa;
                repoDetalle.Agregar(detalle);

                //modifica stock
                productoSeleccionado.stock_producto -= detalle.cantidad_unitario;
                repoProducto.Editar(productoSeleccionado);

                entidad.subtotal_venta += detalle.subtotal_detalleventa;
                entidad.impuesto_venta += detalle.impuesto_detalleventa;
                entidad.total_venta += detalle.total_detalleventa;

            });

            repoVenta.GuardarCambios();
            return entidad;

        }

        public void Anular(Guid entidadId)
        {
            repoVenta.Anular(entidadId);
            repoVenta.GuardarCambios();
        }

        public List<Venta> Listar()
        {
            return repoVenta.Listar();
        }

        public Venta SeleccionarPorID(Guid entidadId)
        {
            return repoVenta.SeleccionarPorID(entidadId);
        }
    }
}

