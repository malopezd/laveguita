using System;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace LaVeguita.API.Models
{
	public class Venta
	{

        //Atributos primitivos
        public Guid id_venta { get; set; }
        public long numero_venta { get; set; }
        public DateTime fecha_venta { get; set; }
        public decimal subtotal_venta { get; set; }
        public decimal impuesto_venta { get; set; }
        public decimal total_venta { get; set; }

        public Boolean anulado { get; set; } = false;

        public List<VentaDetalle>? VentaDetalles { get; set; }


        /*
        //Constructor Vacio de Pedido
        public Pedido()
        {
            this.id_pedido = new int();
            this.estado_pedido = new int();
            this.numeroenvio_pedido = new int();
            this.cliente_pedido = new Cliente();
            this.empleado_pedido = new Empleado();
            this.pago_pedido = new Pago();
            this.productos_pedido = new List<Producto>();
        }
        */
	}
}

