using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LaVeguita.API.Models;
using LaVeguita.API.Services;
using LaVeguita.API.Configs;
using LaVeguita.API.Services.Implementation;
using LaVeguita.API.Services.Repositorio;
using LaVeguita.API.Services.Servicios;
using LaVeguita.API.DbContextos;
using LaVeguita.API.RepositorioDB;

namespace LaVeguita.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        ProductoServicio CrearServicio()
        {
            VentaContext db = new VentaContext();
            ProductoRepositorio repo = new ProductoRepositorio(db);
            ProductoServicio servicio = new ProductoServicio(repo);
            return servicio;  

        }
 
        // GET: api/Producto
        [HttpGet]
        public ActionResult<List<Producto>> Get()
        {
            var servicio = CrearServicio();
            return Ok(servicio.Listar());
        }

        // GET: api/Producto/5
        [HttpGet("{id}")]
        public ActionResult<Producto> Get(Guid id)
        {
            var servicio = CrearServicio();
            return Ok(servicio.SeleccionarPorID(id));
        }

        // POST: api/Producto
        [HttpPost]
        public ActionResult Post([FromBody] Producto producto)
        {
            var servicio = CrearServicio();
            servicio.Agregar(producto);
            return Ok("Agregado correctamente");
        }

        // PUT: api/Producto/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Producto producto)
        {
            var servicio = CrearServicio();
            producto.id_producto = id;
            servicio.Editar(producto);
            return Ok("Editado correcto");
        }

        // DELETE: api/Producto/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var servicio = CrearServicio();
            servicio.Eliminar(id);
            return Ok("Eliminado ok");
        }
    }
}
