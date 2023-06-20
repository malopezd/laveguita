namespace LaVeguita.API.Models
{
    public class Pago
    {
        public Guid id_pago { get; set; }
        public int medio_pago { get; set; }
        public int total_pago { get; set; }

        /*
        public Pago()
        {
            this.id_pago = new int();
            this.medio_pago = new int();
            this.total_pago = new int();
        }
        */
    }
}