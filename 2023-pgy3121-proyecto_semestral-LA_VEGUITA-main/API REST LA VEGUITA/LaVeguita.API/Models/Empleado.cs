namespace LaVeguita.API.Models
{
    public class Empleado
    {
        public Guid id_empleado { get; set; }
        public int rut_empleado { get; set; }
        public string nombre_empleado { get; set; }
        public string direccion_empleado { get; set; }

        /*
        public Empleado()
        {
            this.id_empleado = new int();
            this.rut_empleado = new int();
            this.nombre_empleado = string.Empty;
            this.direccion_empleado = string.Empty;
        }
        */

    }
}