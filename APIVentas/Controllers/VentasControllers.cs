using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIVentas.Models;

namespace APIVentas.Controllers
{
    public class VentasControllers : Controller
    {
        // GET: VentasControllers
        [HttpGet("APIVentas")]
        public IEnumerable<Venta> Get()
        {
            return Venta.ObtenerVentas();
        }
    }
}
