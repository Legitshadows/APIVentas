using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIVentas.Models;

namespace APIVentas.Controllers
{
    public class VentasControllers : Controller
    {
        // GET: VentasControllers - Este Get obtiene todo lo que este registrado en el Ventas.json
        [HttpGet("APIVentas")]
        public IEnumerable<Venta> Get()
        {
            return Venta.ObtenerVentas();
        }

        // GET: VentasControllers - Este Get sirve con el numero de folio para mostrar solo un resultado
        [HttpGet("folio")]
        public IActionResult Get(string folio)
        {
            Venta encontrado = Venta.ObtenerVenta(folio);

            if (encontrado == null)
            {
                return NotFound(null);
            }

            return Ok(encontrado);
        }
    }
}
