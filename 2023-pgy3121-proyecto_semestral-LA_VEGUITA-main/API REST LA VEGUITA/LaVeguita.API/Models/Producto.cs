namespace LaVeguita.API.Models
{
    public class Producto
    {
        public Guid id_producto { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion_producto { get; set; }
        public decimal costo_producto { get; set; }
        public decimal stock_producto { get; set; }
        public decimal precio_producto { get; set; }
        public List<VentaDetalle>? VentaDetalles { get; set; }

        /*
        public Producto()
        {
            this.id_producto = new int();
            this.nombre_producto = string.Empty;
            this.precio_producto = new int();
            this.categoria_producto = new Categoria();
            this.proveedor_producto = new Proveedor();
        }
        */

    }
}