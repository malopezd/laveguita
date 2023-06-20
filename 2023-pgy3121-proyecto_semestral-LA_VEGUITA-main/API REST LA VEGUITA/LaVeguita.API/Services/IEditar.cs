using System;
namespace LaVeguita.API.Services.Implementation
{
	public interface IEditar<TEntidad>
	{
		void Editar(TEntidad entidad);
	}
}

