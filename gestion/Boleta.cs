
namespace TallerMecanico
{
    class Boleta
    {
        //atributos

        private Dictionary<string, int> ServiciosPresios;

        

        
        //constructor
        public Boleta(Dictionary<string, int> serviciosPresios)
        {
           this.ServiciosPresios = serviciosPresios;
        }

        public Dictionary<string, int> Precios
        {
            get {return ServiciosPresios;}
        }

    

        //metodos
        public string CodigoBoleta()
        {
            
            Random random = new Random();
            int codigoAleatorio = random.Next();
            string codigo = $"#House{codigoAleatorio}";
            return codigo;
        }

        public void imprimirBoleta(string direccionTaller, string correoTaller, string telefonoTaller, Cliente cliente)
        {
            
            DateTime fecha = DateTime.Now;
            string fechaBoleta = fecha.ToString("yyyyMMddHHmm");

            string numeroBoleta = Guid.NewGuid().ToString().Substring(0, 8);
            IPersona persona = cliente;
            try
            {    using (StreamWriter sw = new StreamWriter("Boleta.txt"))
                {
                    sw.WriteLine("------------------------------------------------------------");
                    sw.WriteLine($"                         BOLETA                            ");
                    sw.WriteLine("------------------------------------------------------------");
                    sw.WriteLine($" Taller Mecánico: Taller Gregory House");
                    sw.WriteLine($" Dirección: {direccionTaller  }");
                    sw.WriteLine($" Teléfono: {telefonoTaller}");
                    sw.WriteLine($" Correo Electrónico: {correoTaller}");
              
                    sw.WriteLine("------------------------------------------------------------");
                    sw.WriteLine($" Fecha: {fecha}");
                    sw.WriteLine($" Boleta #: {numeroBoleta}");
                    sw.WriteLine("------------------------------------------------------------");

                    sw.WriteLine($" Cliente: {persona.NombrePersona}");
                    sw.WriteLine($" Dirección del Cliente: {persona.GetCorreo}");
                    sw.WriteLine($" Teléfono del Cliente: {persona.GetDireccion}");
                    sw.WriteLine("------------------------------------------------------------");
                    sw.WriteLine($" Descripción                      |  Total   ");
                    sw.WriteLine("------------------------------------------------------------");

                    //servicios realizados 
                   
                    int total = 0;

                    //Para cada vehiculo del cliente se extraen los servicios realizados y sus precios, se se calcula el cobro a cada vehiculo y luego se suma al total 
                    foreach (Vehiculo vehiculo in cliente.GetListaDeVehiculos)
                    {
                        List<String> listaServicios = vehiculo.ListaDeServiciosRealizados;
                        int i = 0;
                        List<String> listaPreciosPorNombre= ServiciosPresios.Keys.ToList();
                        List<int> listaPreciosPorPrecio= ServiciosPresios.Values.ToList();
                        int totalCobro = 0;

                        while(i< listaServicios.Count)
                        {
                            //comparar los servicios realizados con los servicios y sus precios
                            if( ServiciosPresios.ContainsKey(listaServicios[i]))
                            {
                                int valor = ServiciosPresios[listaServicios[i]];
                               
                                sw.WriteLine($"Servicio:  {listaServicios[i]} Costo:  {valor}");
                                totalCobro += listaPreciosPorPrecio[i];
                            }
                            i++;
                        }
                        sw.WriteLine($"Total del vehiculo {vehiculo.GetMarca}   {vehiculo.GetModelo }  :  ${totalCobro}");
                        total += totalCobro;
                    }



                    sw.WriteLine("------------------------------------------------------------");
                    sw.WriteLine($" Total a Pagar: | ${total, -10:F2}");
                    sw.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Boleta creada exitosamente en el archivo: Boleta.txt" );
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Ocurrio un error al generar la boleta: " + ex.Message);
            }
        }
    }
}