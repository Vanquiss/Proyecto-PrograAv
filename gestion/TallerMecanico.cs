using System.Dynamic;

namespace TallerMecanico{


    class TallerMecanico
    {
        //vars
        public List<Cliente> ListaClientes;

        public List<Trabajadores> ListaTrabajadores;

        public List<Vehiculo> ListaVehiculos;

        public List<Pedido> PedidosActivos;

        public List<Pedido> Pedidosinactivos;

        public List<String> AlmacenVehiculos;







        //constructor

        public TallerMecanico(List<Cliente> listaClientes,List<Trabajadores> listaTrabajadores,
                              List<Vehiculo> listaVehiculos,
                              List<Pedido> pedidosActivos,
                              List<Pedido> pedidosinactivos,
                              List<String> almacenVehiculos)
        {
            ListaClientes = listaClientes;
            ListaTrabajadores = listaTrabajadores;
            ListaVehiculos = listaVehiculos;
            PedidosActivos = pedidosActivos;
            Pedidosinactivos = pedidosinactivos;
            AlmacenVehiculos = almacenVehiculos;

        }
        


        //metodos


        ////////GESTION DE CLIENTES/////////
        
        //Cliente por default  (SOBRECARGA DE METODOS) 1
        public Cliente CrearCliente()
        {
            Random random = new Random();
            List<Vehiculo> listaVehiculosCliente = new List<Vehiculo>();
            int numAleatorio = random.Next(100, 900);
            int numAleatorio2 = random.Next(100, 900);
            int edad = random.Next(18, 90);
            Cliente cliente = new Cliente($"17.{numAleatorio.ToString()}.{numAleatorio2.ToString()}-8", "Manwako de Ejemplo ", edad, "manwako@gmail.com", "ManwakoStreet", "manwako number", "credito", listaVehiculosCliente);

            int matriculaAleatoria = random.Next(100, 900);
            Vehiculo vehiculoDefault = new AutoPasajeros("Ferrari", "488 GTB", 2014, $"BC {matriculaAleatoria}",cliente, 4, "deportivo", "Rojo");
            listaVehiculosCliente.Add(vehiculoDefault);
            this.AniadirCliente(cliente);
            Console.WriteLine($"/////  Rut Aleatorio Creado: {cliente.GetRut},  Matricula Aleatoria Creada: {vehiculoDefault.GetMatricula}");
            return cliente;
        }
        
        //Cliente creado por consola
        public Cliente CrearCliente(string rut,string nombre,int edad, int numeroVehiculos, String CorreoElectronico, String Dierccion, string numeroTelefonico, String MetodoPago, TallerMecanico taller)
        {
            

            //el cliente comienza con una lista vacia de vehiculos
            List<Vehiculo> listaVehiculosCliente = new List<Vehiculo>();

            //COMPOSICION
            Cliente cliente = new Cliente(rut,nombre,edad,CorreoElectronico, Dierccion, numeroTelefonico, MetodoPago, listaVehiculosCliente);


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

                        
                        AutoPasajeros vehiculo = new AutoPasajeros(marca, modelo,anio,matricula,cliente, numeroPuertas, carroceria,color);
                        listaVehiculosCliente.Add(vehiculo);
                        break;
                    case 2:
                        Console.WriteLine("Ingresa Caracteristicas adicionales al tipo de vehiculo: 'tipo de camion', 'capacidad de carga'");
    
                        string tipoCamion = Console.ReadLine();
                        int capacidadCarga = int.Parse(Console.ReadLine());
                        Camiones vehiculo2 = new Camiones(marca, modelo,anio,matricula,cliente,tipoCamion, capacidadCarga);
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

        public void BuscarCliente(string rut)
        {
            foreach(Cliente cliente in ListaClientes)
            {
                if(cliente.GetRut == rut){
                    Console.WriteLine($"Informacion de Ciente: ");
                    cliente.Informacion();
                }
            }
        }  
        public void ListaDeClientes()
        {
            
            foreach (Cliente cliente in ListaClientes)
            {
                Console.WriteLine($"Nombre: {cliente.NombrePersona}, Rut: {cliente.GetRut}");
            }
        }
        public void AniadirCliente(Cliente nuevoCliente)
        {
            ListaClientes.Add(nuevoCliente);
        }

        public void EliminarCliente(String rut)
        {

            /////no funciona bien
            int i = 0; 
            foreach(Cliente cliente in ListaClientes)
            {

                if(cliente.GetRut == rut){
                    bool eliminacion = ListaClientes.Remove(ListaClientes[i]);
                    if(eliminacion)
                    {
                        Console.WriteLine($"El cliente {cliente.NombrePersona} se ha eliminado correctamente");

                    }
                }  
                // try
                // {
                    
                // }catch(KeyNotFoundException ex)
                // {
                //     Console.WriteLine("Error: El Rut ingresado no pertenece a ningun cliente: " + ex.Message);
                // }
                i++;
            }
            
        }




        
        ///////GESTION DE SERVICIO////////

        //servicios disponibles

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
            Console.WriteLine($"/////  {vehiculo.GetMarca}  /////");

            for(int i = 0; i<=100;i++)
            {
                Random random = new Random();
                int numAleatorio = random.Next(30, 70);
                Console.WriteLine($"///// Realizando Cambio de Aceite al vehiculo:  {i}%");
               
                Thread.Sleep(numAleatorio); 
            }
            Console.WriteLine($"///// CAMBIO DE ACEITE COMPLETADO /////");
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
            Console.WriteLine($"///// FRENOS REPARADOS  /////");
        }

        public void ReparacionMotor(Vehiculo vehiculo)
        {
            
        }

        public void ReparacionSistemasElectricos(Vehiculo vehiculo)
        {
            
        }

        public void MantenimientoRegular()
        {
            
        }
        //gestion trabajadores

        public void BuscarTrabajador(string rut)
        {
            foreach(Trabajadores empleado in ListaTrabajadores)
            {

                if(empleado.GetRut == rut){
                    Console.WriteLine($"Nombre: {empleado.Informacion}");
                }
            }
        }  

    }




}