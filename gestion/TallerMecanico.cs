using System.Dynamic;

namespace TallerMecanico{


    class TallerMecanico
    {
        //vars
        public List<Cliente> ListaClientes;

        public List<Vehiculo> ListaVehiculos;

        public List<Pedido> PedidosActivos;

        public List<Pedido> Pedidosinactivos;

        public List<String> AlmacenVehiculos;






        //constructor

        public TallerMecanico(List<Cliente> listaClientes,
                              List<Vehiculo> listaVehiculos,
                              List<Pedido> pedidosActivos,
                              List<Pedido> pedidosinactivos,
                              List<String> almacenVehiculos)
        {
            ListaClientes = listaClientes;
            ListaVehiculos = listaVehiculos;
            PedidosActivos = pedidosActivos;
            Pedidosinactivos = pedidosinactivos;
            AlmacenVehiculos = almacenVehiculos;

        }
        


        //metodos


        ////////GESTION DE CLIENTES/////////

        public Cliente CrearCliente(string nombre, int numeroVehiculos, String CorreoElectronico, String Dierccion, String MetodoPago, TallerMecanico taller)
        {
            

            //el cliente comienza con una lista vacia de vehiculos
            List<Vehiculo> listaVehiculosCliente = new List<Vehiculo>();

            //COMPOSICION
            Cliente cliente = new Cliente(nombre, listaVehiculosCliente, CorreoElectronico, Dierccion, MetodoPago);


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
        public void ListaDeClientes()
        {
            foreach (Cliente cliente in ListaClientes)
            {
                Console.WriteLine(cliente.NombreCliente);
            }
        }
        public void AniadirCliente(Cliente nuevoCliente)
        {
            ListaClientes.Add(nuevoCliente);
        }




        
        ///////GESTION DE VEHICULOS////////



        //gestion trabajadores

    }




}