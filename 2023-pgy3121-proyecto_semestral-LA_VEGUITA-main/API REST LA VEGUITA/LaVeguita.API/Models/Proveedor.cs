namespace LaVeguita.API.Models
{
    public class Proveedor
    {
        public Guid id_proveedor { get; set; }
        public int rut_proveedor { get; set; }
        public string nombre_proveedor { get; set; }
        public string direccion_proveedor { get; set; }

        /*
        public Proveedor()
        {
            this.id_proveedor = new int();
            this.rut_proveedor = new int();
            this.nombre_proveedor = string.Empty;
            this.direccion_proveedor = string.Empty;
        }
        */
    }
}