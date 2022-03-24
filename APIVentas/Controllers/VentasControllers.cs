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

        // POST: VentasControllers - Este Post sirve para crear una nueva entrada en el json siguiendo lo que tenemos en #Datos
        [HttpPost("APIVentas")]
        public void Post([FromBody] Venta value)
        {
            Venta.AgregarVentas(value);
        }

        // PUT: VentasControllers - Este Put sirve para actualizar los datos dentro de nuestro json utilizando folio para saber cual queremos modificar
        [HttpPut("folio")]
        public IActionResult Put(string folio, [FromBody] Venta value)
        {
            bool resultado = Venta.ActualizarVenta(folio, value);

            if (!resultado)
            {
                return NotFound();
            }

            return Ok();
        }

        // DELETE: VentasControllers - Delete permite borrar entradas en el json mediante su # de folio
        [HttpDelete("folio")]
        public IActionResult Delete(string folio)
        {
            bool resultado = Venta.EliminarVenta(folio);

            if (!resultado)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
