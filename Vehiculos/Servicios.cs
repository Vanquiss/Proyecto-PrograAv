using System.Threading;


namespace TallerMecanico
{
    class Servicios
    {
        //atributos
        private bool Activo;

        private string Fecha;
        private string boleta;
        private string factura;


        //constructor
        public Servicios(string fecha)
        {
            this.Fecha = fecha;
        }


        //metodos
       


       




        //
        public void GenerarBoleta()
        {
            string rutaArchivo = "archivo.txt";
            try
            {    using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    sw.WriteLine("------------------------------------------------------------");
                    sw.WriteLine($"                         BOLETA                            ");
                    sw.WriteLine("------------------------------------------------------------");
                    //sw.WriteLine($" Taller Mecánico: {nombreTaller}");
                    // sw.WriteLine($" Dirección: {direccionTaller}");
                    // sw.WriteLine($" Teléfono: {telefonoTaller}");
                    // sw.WriteLine($" Correo Electrónico: {correoTaller}");
                    // sw.WriteLine($" NIT: {nitTaller}");
                    // sw.WriteLine("------------------------------------------------------------");
                    // sw.WriteLine($" Fecha: {fecha}");
                    // sw.WriteLine($" Boleta #: {numeroBoleta}");
                    // sw.WriteLine("------------------------------------------------------------");
                    // sw.WriteLine($" Cliente: {nombreCliente}");
                    // sw.WriteLine($" Dirección del Cliente: {direccionCliente}");
                    // sw.WriteLine($" Teléfono del Cliente: {telefonoCliente}");
                    // sw.WriteLine("------------------------------------------------------------");
                    // sw.WriteLine($" Descripción                      |  Total   ");
                    // sw.WriteLine("------------------------------------------------------------");
                    // for (int i = 0; i < servicios.Length; i++)
                    // {
                    //     sw.WriteLine($" {servicios[i],-30} |  ${precios[i],-7:F2}");
                    // }
                    // sw.WriteLine("------------------------------------------------------------");
                    // sw.WriteLine($" Total a Pagar: | ${total, -10:F2}");
                    sw.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Boleta creada exitosamente en el archivo: " + rutaArchivo);
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Ocurrio un error al generar la boleta: " + ex.Message);
            }
        }




    }
}