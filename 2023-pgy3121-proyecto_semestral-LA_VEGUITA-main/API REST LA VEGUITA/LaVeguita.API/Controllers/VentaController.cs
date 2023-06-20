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
    public class VentaController : ControllerBase
    {
        VentaServicio CrearServicio()
        {
            VentaContext db = new VentaContext();
            VentaRepositorio repoVenta = new VentaRepositorio(db);
            ProductoRepositorio repoProducto = new ProductoRepositorio(db);
            VentaDetalleRepositorio repoDetalle = new VentaDetalleRepositorio(db);
            VentaServicio servico = new VentaServicio(repoVenta, repoProducto, repoDetalle);
            return servico;
        }

        // GET: api/Venta
        [HttpGet]
        public ActionResult<List<Venta>> Get()
        {
            var servicio = CrearServicio();
            return Ok(servicio.Listar());
        }

        // GET: api/Venta/5
        [HttpGet("{id}")]
        public ActionResult<Venta> Get(Guid id)
        {
            var servicio = CrearServicio();
            return Ok(servicio.SeleccionarPorID(id));
        }

        // POST: api/Venta
        [HttpPost]
        public ActionResult Post([FromBody] Venta venta)
        {
            var servicio = CrearServicio();
            servicio.Agregar(venta);
            return Ok("Venta guardada");
        }


        // DELETE: api/Venta/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var servicio = CrearServicio();
            servicio.Anular(id);
            return Ok("Venta anulada ok");
        }
    }
}
