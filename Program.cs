
using System.Dynamic;
using System.Collections.Generic;
namespace TallerMecanico{


    class Program
    {   
        static void Main(string[] args)
        {


            //listas vacias

            List<Vehiculo> listaVehiculosTaller = new List<Vehiculo>();

            List<Cliente> listaClientes = new List<Cliente>();

            List<Pedido> listaPedidos = new List<Pedido>();

            List<Pedido> listaPedidosActivos = new List<Pedido>();

            List<Pedido> listaPedidosInactivos = new List<Pedido>();

            List<string> almacenVehiculos = new List<string>();

            



            //instancia Taller Mecanico
            TallerMecanico tallerMecanico = new TallerMecanico(listaClientes, listaVehiculosTaller,listaPedidosActivos,listaPedidosInactivos,almacenVehiculos);

            //interfaz en consola

            //preguntar que quiere hacer el operario

                //crear cliente
            Cliente cliente1 = CrearCliente("Manwako de ejemplo", 4,"manwako@gmail.com","abskjdb", "rial money", tallerMecanico);

            Console.WriteLine($"El Cliente {cliente1.NombreCliente} tiene la siguiente lista de vehiculos:");
            cliente1.ImprimeListaDeVehiculos();
            tallerMecanico.AniadirCliente(cliente1);

        }








        static Cliente CrearCliente(string nombre, int numeroVehiculos, String CorreoElectronico, String Dierccion, String MetodoPago, TallerMecanico taller)
        {
            

            //el cliente comienza con una lista vacia de vehiculos
            List<Vehiculo> listaVehiculosCliente = new List<Vehiculo>();
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
                        int numeroPuertas = int.Parse(Console.ReadLine());
                        string carroceria = Console.ReadLine();
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
        

    }




}