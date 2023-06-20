using System;
namespace LaVeguita.API.Models
{
	public class Cliente
	{
		public Guid id_cliente { get; set; }
		public int rut_cliente { get; set; }
		public string nombre_cliente { get; set; }
		public string direccion_cliente { get; set; } 

		/*
		public Cliente()
		{
			this.id_cliente = new int();
			this.rut_cliente = new int();
			this.nombre_cliente = string.Empty;
			this.direccion_cliente = string.Empty;
		}
		*/
	}
}

