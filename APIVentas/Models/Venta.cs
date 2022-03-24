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

        public static Venta ObtenerVenta(string folio)
        {
            IEnumerable<Venta> listaVentas = ObtenerVentas();
            Venta encontrado = listaVentas.Where(x => x.Folio == folio).SingleOrDefault();
            return encontrado;
        }

        public static void AgregarVentas (Venta value)
        {
            string fileName = @".\Models\Ventas.json";
            List<Venta> listaVentas = ObtenerVentas().ToList();
            listaVentas.Add(value);
            string jsonString = System.Text.Json.JsonSerializer.Serialize(listaVentas);
            System.IO.File.WriteAllText(fileName, jsonString);
        }
        #endregion
    }
}
