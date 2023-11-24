using System.Dynamic;

namespace TallerMecanico{


    class TallerMecanico
    {
        //atributos

        private string Direccion;

        private string Telefono;

        private string CorreoElectronico;

        public List<Cliente> ListaClientes;

        public List<Trabajadores> ListaTrabajadores;

        public List<Vehiculo> ListaVehiculos;
        public List<String> AlmacenVehiculos;

        private List<String> Servicios;







        //constructor

        public TallerMecanico(List<Cliente> listaClientes,List<Trabajadores> listaTrabajadores,
                              List<Vehiculo> listaVehiculos,
                              string direccion,
                              string correoElectronico,
                              string telefono,
                              List<String> almacenVehiculos)
        {
            ListaClientes = listaClientes;
            ListaTrabajadores = listaTrabajadores;
            ListaVehiculos = listaVehiculos;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
            AlmacenVehiculos = almacenVehiculos;
        }
        


        //metodos


        ////////GESTION DE CLIENTES/////////
        
        //Cliente por default  (SOBRECARGA DE METODOS) 1
        public Cliente CrearCliente()
        {
            Random random = new Random();
            List<Vehiculo> listaVehiculosCliente = new List<Vehiculo>();
             List<string> listaServiciosRealizados = new List<string>();
            int numAleatorio = random.Next(100, 900);
            int numAleatorio2 = random.Next(100, 900);
            int edad = random.Next(18, 90);
            Cliente cliente = new Cliente($"17.{numAleatorio.ToString()}.{numAleatorio2.ToString()}-8", "Manwako de Ejemplo ", edad, "manwako@gmail.com", "ManwakoStreet", "manwako number", "credito", listaVehiculosCliente);
           
           
            IPersona persona = cliente;
            persona.GetRut = $"17.{numAleatorio.ToString()}.{numAleatorio2.ToString()}-8";
            persona.GetDireccion = "ManwakoStreet";
            persona.CorreoElectronico = "Manwako@gmail.com";
            persona.EdadPersona = 20;
            persona.NombrePersona = "Manwako";
            persona.Telefono = "93757275";
            
            int matriculaAleatoria = random.Next(100, 900);
            Vehiculo vehiculoDefault = new AutoPasajeros("Ferrari", "488 GTB", 2014, $"BC {matriculaAleatoria}",cliente,listaServiciosRealizados, 4, "deportivo", "Rojo");
            listaVehiculosCliente.Add(vehiculoDefault);
            this.AniadirCliente(cliente);

            Console.WriteLine($"/////  Rut Aleatorio Creado: {cliente.GetRut},  Matricula Aleatoria Creada: {vehiculoDefault.GetMatricula}");
            return cliente;
        }
        
        //Cliente creado por consola
        public Cliente CrearCliente(string rut,string nombre,int edad, int numeroVehiculos, String CorreoElectronico, String Diereccion, string numeroTelefonico, String MetodoPago, TallerMecanico taller)
        {
            

            //el cliente comienza con una lista vacia de vehiculos
            List<Vehiculo> listaVehiculosCliente = new List<Vehiculo>();
            
            //COMPOSICION
            Cliente cliente = new Cliente(rut,nombre,edad,CorreoElectronico, Diereccion, numeroTelefonico, MetodoPago, listaVehiculosCliente);
            IPersona persona = cliente;
            persona.GetRut = rut;
            persona.GetDireccion = Diereccion;
            persona.CorreoElectronico = CorreoElectronico;
            persona.EdadPersona = edad;
            persona.NombrePersona = nombre;
            persona.Telefono = numeroTelefonico;

            //crea la cantidad de vehiculos indicada y las asigan a la lista vehiculos del cliente
            Console.WriteLine($"Ingrese el tipo de vehiculo y los  Datos de los {numeroVehiculos} vehiculos del cliente");
            for(int i = 1; i <= numeroVehiculos; i++)
            {
                Console.WriteLine($"////// Vehiculo {i} ///////");
                Console.WriteLine("Ingrese un numero para el tipo de vehiculo, 1 => 'Auto', 2 => 'Camion', 3 => 'Moto', 4 => 'Utilitario' ");
                
                int tipoVehiculo = int.Parse(Console.ReadLine());
                Console.WriteLine("Marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Modelo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Anio: ");
                int anio = int.Parse(Console.ReadLine());
                Console.WriteLine("Matricula: ");
                string matricula = Console.ReadLine();

                //se crean los vehiculos segun tipo, se asignan caracteristicas especiales de cada tipo de vehiculo y se aniaden a la lista de vehiculos del cliente
                switch (tipoVehiculo)
                {
                    case 1:
                        Console.WriteLine("Ingresa Caracteristicas adicionales al tipo de vehiculo: 'Numero de puertas', 'carroceria', 'color'");
                        Console.Write("Numero de Puertas: ");
                        int numeroPuertas = int.Parse(Console.ReadLine());
                        Console.Write("Tipo de Carroceria (cedan): ");
                        string carroceria = Console.ReadLine();
                        Console.Write(" (cedan) ");
                        string color = Console.ReadLine();

                        List<string> listaServiciosRealizados = new List<string>();
                        AutoPasajeros vehiculo = new AutoPasajeros(marca, modelo,anio,matricula,cliente,listaServiciosRealizados, numeroPuertas, carroceria,color);
                        listaVehiculosCliente.Add(vehiculo);
                        break;
                    case 2:
                        Console.WriteLine("Ingresa Caracteristicas adicionales al tipo de vehiculo: 'tipo de camion', 'capacidad de carga'");
    
                        string tipoCamion = Console.ReadLine();
                        int capacidadCarga = int.Parse(Console.ReadLine());

                        List<string> listaServiciosRealizados2 = new List<string>();
                        Camiones vehiculo2 = new Camiones(marca, modelo,anio,matricula,cliente,listaServiciosRealizados2,tipoCamion, capacidadCarga);
                        listaVehiculosCliente.Add(vehiculo2);
                        break;
                    //falta los demas vehiculos
                }
                //end for
            }
            //se aniade el cliente al taller
            taller.AniadirCliente(cliente);
            return cliente;

        } 

        public Cliente BuscarCliente(string rut)
        {
            foreach(Cliente cliente in ListaClientes)
            {
                IPersona persona = cliente;
                if(persona.GetRut == rut){
                    Console.WriteLine($"Informacion de Ciente: ");
                    cliente.Informacion();
                    return cliente;
                }
            }
            Console.WriteLine($"/////  Cliente no encontrado");
            return null;
        }  
        public void ListaDeClientes()
        {
            if(ListaClientes.Count != 0)
            {
                foreach (Cliente cliente in ListaClientes)
                {
                    IPersona persona = cliente;
                    Console.WriteLine($"Nombre: {persona.NombrePersona}, Rut: {persona.GetRut}");
                }
            }else
            {
                Console.WriteLine("No hay clientes en la lista");
            }
        }

        public void AniadirCliente(Cliente nuevoCliente)
        {
            ListaClientes.Add(nuevoCliente);
        }



        //utiiza excepcion
        public void EliminarCliente(String rut)
        {

            /////no funciona bien
          

            for (int i = ListaClientes.Count - 1; i >= 0; i--)
{               
                Cliente cliente = ListaClientes[i];
                IPersona persona = cliente;
                try
                {
                    if(cliente.GetRut == rut){
                        ListaClientes.Remove(cliente);
                        
                        if(!ListaClientes.Contains(cliente))
                        {

                            Console.WriteLine($"El cliente {persona.NombrePersona} se ha eliminado correctamente");

                        }
                    }
                } catch(KeyNotFoundException ex)
                {
                    Console.WriteLine("Error al ingresar el RUT: : " + ex.Message);
                }
            }
        
        }




        
        ///////GESTION DE SERVICIO////////
        public List<string> ListaServicios
        {
            get {return Servicios;}
        }

        public void AniadirServicio(string servicio)
        {
            ListaServicios.Add(servicio);
        }
        

        //SOBRE CARGA  DE METODOS 2
        // Si los parametros son la matricula y un cliente, se busca solo en los vehiculos de ese cliente, si solo se entrega la matricula, se busca en los vehiculos de de todos los clientes
        public Vehiculo BuscarVehiculo(string matricula, Cliente cliente)
        {
            
            List<Vehiculo> lista = cliente.GetListaDeVehiculos;
            foreach(Vehiculo vehiculo in lista)
            {
        
                if(vehiculo.GetMatricula == matricula){
                    return  vehiculo;
                }
            }
            
            // si no retorna nada entonces el vehiculo no se encuentra
            Console.WriteLine($"Vehiculo con matricula '{matricula}' no encontrado");
            return null;
        }
        public Vehiculo BuscarVehiculo(string matricula)
        {
            foreach(Cliente cliente in ListaClientes)
            {
                List<Vehiculo> lista = cliente.GetListaDeVehiculos;
                foreach(Vehiculo vehiculo in lista)
                {
            
                    if(vehiculo.GetMatricula == matricula){
                        return  vehiculo;
                    }
                }
            }

            // si no retorna nada entonces el vehiculo no se encuentra
            Console.WriteLine($"Vehiculo con matricula '{matricula}' no encontrado");
            return null;
        }
        public void CambioAceite(Vehiculo vehiculo)
        {
            if (vehiculo != null)
    {
                Console.WriteLine($"/////  {vehiculo.GetMarca}  /////");

                for (int i = 0; i <= 100; i++)
                {
                    Random random = new Random();
                    int numAleatorio = random.Next(30, 70);
                    Console.WriteLine($"///// Realizando Cambio de Aceite al vehiculo:  {i}%");
                
                    Thread.Sleep(numAleatorio); 
                }
                vehiculo.AniadirServicioRealizado("CAMBIO DE ACEITE");
                Console.WriteLine($"///// CAMBIO DE ACEITE COMPLETADO /////");
            }
            else
            {
                Console.WriteLine("El objeto Vehiculo es nulo.");
            }
        }

        public void RepararFrenos(Vehiculo vehiculo)
        {
            Console.WriteLine($"/////  {vehiculo.GetMarca}  /////");

            for(int i = 0; i<=100;i++)
            {
                Console.WriteLine($"///// Freno   :  {i}%");
                Thread.Sleep(10); 
                
            }
            Console.WriteLine($"'\n' '\n'");
            for(int i = 0; i<=100;i++)
            {
                Console.WriteLine($"///// Freno 2 :  {i}%");
                Thread.Sleep(10); 
                
            }
            Console.WriteLine($"'\n' '\n'");
            for(int i = 0; i<=100;i++)
            {
                Console.WriteLine($"///// Freno 3 :  {i}%");
                Thread.Sleep(10); 
                
            }
            Console.WriteLine($"'\n' '\n'");
            for(int i = 0; i<=100;i++)
            {
                Console.WriteLine($"///// Freno 4 :  {i}%");
                Thread.Sleep(10); 
                
            }
            Console.WriteLine($"'\n' '\n'");
            vehiculo.AniadirServicioRealizado("REPARACION FRENOS");
            Console.WriteLine($"///// FRENOS REPARADOS  /////");

            
        }

        public void ReparacionMotor(Vehiculo vehiculo)
        {
            
        }

        public void CambioComponente(Vehiculo vehiculo)
        {
            Console.WriteLine("//// 1.- Cambio de Neumatico: 150$");
            Console.WriteLine("//// 2.- Cambio Filtro aceite Motor: 100$");
           
            
           
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    Console.WriteLine("//// Cambio de Neumatico Realizado");
                    vehiculo.AniadirServicioRealizado("CAMBIO DE NEUMATICO");
                    break;
                case 2:
                    Console.WriteLine("//// Cambio de Filtro Aceite Realizado");
                    vehiculo.AniadirServicioRealizado("CAMBIO FILTRO DE ACEITE");
                    break;
            }

        }

        public void MantenimientoRegular()
        {
            
        }


        public void GenerarBoleta(Cliente cliente)
        {
            Dictionary<string, int> ServiciosPresios = new Dictionary<string, int>();
            ServiciosPresios["CAMBIO FILTRO DE ACEITE"] =  100;
            ServiciosPresios["CAMBIO DE NEUMATICO"] = 100;
            ServiciosPresios["REPARACION FRENOS"] = 150;
            ServiciosPresios["CAMBIO DE ACEITE"] = 100;
            Boleta boleta = new Boleta(ServiciosPresios);
            boleta.imprimirBoleta(this.Direccion, this.CorreoElectronico,this.Telefono,cliente);
        }



        //gestion trabajadores

        public void BuscarTrabajador(string rut)
        {
            foreach(Trabajadores empleado in ListaTrabajadores)
            {
                IPersona persona = empleado;
                if(persona.GetRut == rut){
                    empleado.Informacion();
                }
            }
        }  

    }




}