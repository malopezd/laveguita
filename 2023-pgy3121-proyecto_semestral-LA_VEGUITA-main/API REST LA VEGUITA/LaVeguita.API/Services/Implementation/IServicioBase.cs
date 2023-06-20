using System;
using LaVeguita.API.Services;

namespace LaVeguita.API.Services.Implementation
{
	public interface IServicioBase<TEntidad, TEntidadID>
		: IAgregar<TEntidad>, IEditar<TEntidad>, IEliminar<TEntidadID>, IListar<TEntidad, TEntidadID>
	{
	}
}

