using System;
using LaVeguita.API.Services;
using LaVeguita.API.Services.Implementation;

namespace LaVeguita.API.Services.Repositorio

{
	public interface IRepoBase<TEntidad, TEntidadID>
	
		: IAgregar <TEntidad>, IEditar<TEntidad>, IEliminar<TEntidadID>, IListar<TEntidad, TEntidadID>, ITransaccion { 
	}
}

