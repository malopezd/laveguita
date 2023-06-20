using System;
namespace LaVeguita.API.Services
{
	public interface IAgregar<TEntidad>
	{
		TEntidad Agregar(TEntidad entidad);
	}
}

