namespace APIVentas.Models
{
    public class Venta
    {
        #region "Datos"
        public string Folio { get; set; }
        public DateTime Fecha { get; set; }
        public double Cantidad { get; set; }
        public decimal Total { get; set; }
        #endregion

        #region "Metodos"
        public static IEnumerable<Venta> ObtenerVentas()
        {
            string fileName = @".\Models\Ventas.json";
            string jsonString = System.IO.File.ReadAllText(fileName);
            List<Venta> listaVentas = System.Text.Json.JsonSerializer.Deserialize<List<Venta>>(jsonString).ToList();
            return listaVentas;
        }
        #endregion
    }
}
