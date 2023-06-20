using System;
using LaVeguita.API.Services;

namespace LaVeguita.API.Services.Repositorio
{
	public interface IRepoDetalleVenta<TEntidad, TMovimientoID>
		: IAgregar<TEntidad>, ITransaccion
	{
	}
}

