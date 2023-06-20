using System;
namespace LaVeguita.API.Models
{
	public class VentaDetalle
	{
		public Guid id_producto { get; set; }
		public Guid id_venta { get; set; }
        public decimal costo_unitario { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal cantidad_unitario { get; set; }
        public decimal subtotal_detalleventa { get; set; }
        public decimal impuesto_detalleventa { get; set; }
        public decimal total_detalleventa { get; set; }
        public Producto Producto { get; set; }
        public Venta Venta { get; set; }
    }
}

