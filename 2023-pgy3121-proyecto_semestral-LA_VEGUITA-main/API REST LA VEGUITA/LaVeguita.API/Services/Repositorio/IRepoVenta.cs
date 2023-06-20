using System;
using LaVeguita.API.Services;
using LaVeguita.API.Services.Implementation;

namespace LaVeguita.API.Services.Repositorio
{
	public interface IRepoVenta<TEntidad, TEntidadID>
		: IAgregar<TEntidad>, IListar<TEntidad, TEntidadID>, ITransaccion
    {
		void Anular(TEntidadID entidadId);
	}
}

