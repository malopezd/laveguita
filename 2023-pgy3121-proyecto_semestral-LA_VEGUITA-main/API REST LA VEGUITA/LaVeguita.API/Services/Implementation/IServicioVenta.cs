using System;
using LaVeguita.API.Services;

namespace LaVeguita.API.Services.Implementation
{
	public interface IServicioVenta<TEntidad, TEntidadID>
        : IAgregar<TEntidad>, IListar<TEntidad, TEntidadID>
    {
        void Anular(TEntidadID entidadId);
	}
}

