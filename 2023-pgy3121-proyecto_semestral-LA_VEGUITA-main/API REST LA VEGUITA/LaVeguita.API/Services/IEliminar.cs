using System;
namespace LaVeguita.API.Services
{
	public interface IEliminar<TEntidadID>
	{
		void Eliminar(TEntidadID entidadId);
	}
}

