
using System.Dynamic;
using System.Collections.Generic;
namespace TallerMecanico{


    class Program
    {   
        static void Main(string[] args)
        {

            bool tallerAbierto = true;


            //listas vacias

            List<Vehiculo> listaVehiculosTaller = new List<Vehiculo>();

            List<Cliente> listaClientes = new List<Cliente>();

            List<Pedido> listaPedidos = new List<Pedido>();

            List<Pedido> listaPedidosActivos = new List<Pedido>();

            List<Pedido> listaPedidosInactivos = new List<Pedido>();

            List<string> almacenVehiculos = new List<string>();

            //instancia Taller Mecanico
            TallerMecanico tallerMecanico = new TallerMecanico(listaClientes, listaVehiculosTaller,listaPedidosActivos,listaPedidosInactivos,almacenVehiculos);

            while(Interfaz(tallerAbierto, tallerMecanico));
            
        }

        static bool Interfaz(bool tallerAbierto, TallerMecanico tallerMecanico)
        {
            Console.WriteLine("              ////////// TALLER GREGORY HOUSE //////////   ");


            Console.WriteLine("////////// Presione un numero para realizar operaciones del taller");
            Console.WriteLine("////////// 1.- Gestion De Clientes: ");
            Console.WriteLine("////////// 2.- Gestion De Vehiculos: ");
            Console.WriteLine("////////// 3.- Gestion De Trabajadores: ");

            Console.WriteLine("\n", "\n");
            Console.WriteLine("////////// 9.- Cerrar Taller: ");
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    while(InterfazGesClientes(tallerMecanico));
                    return tallerAbierto = true;
                    
                case 9:
                    Console.WriteLine("////////// TALLER CERRADO //////////");
                    return tallerAbierto = false;
                default:
                    return tallerAbierto = true;
            }
        }

        static bool InterfazGesClientes(TallerMecanico tallerMecanico)
        {
            bool InterfazAbierta = true;
           
            Console.WriteLine("////////// Gestion De Clientes: ");
            Console.WriteLine("////////// Presione un numero para realizar operaciones de clientes");
            Console.WriteLine("////////// 1.- Crear Cliente: ");
            Console.WriteLine("////////// 2.- Eliminar Cliente: ");
            Console.WriteLine("////////// 3.- Ver lista de clientes: ");
            Console.WriteLine("////////// 4.- Volver a operaciones del taller: ");
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    Console.WriteLine("///// Datos del Cliente");
                    Console.WriteLine("///// Nombre ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("///// Numero de vehiculos ");
                    int numeroVehiculos = int.Parse(Console.ReadLine());
                    Console.WriteLine("///// Correo Electronico");
                    string correoElectronico = Console.ReadLine();
                    Console.WriteLine("///// Metodo de Pago");
                    string metodoPago = Console.ReadLine();
                    Console.WriteLine("///// Direccion");
                    string direccion = Console.ReadLine();

                    Console.WriteLine("///// '\n");
                    tallerMecanico.CrearCliente(nombre,numeroVehiculos,correoElectronico, metodoPago,direccion,tallerMecanico);
                    Console.WriteLine("///// El cliente ha sido creado exitosamente  y ha sido aniadido a la lista de clientes del taller");
                    return InterfazAbierta = true;
                case 2:
                    Console.WriteLine("///// Datos del Cliente");
                    Console.WriteLine("///// Nombre ");
                    string nombreEliminar = Console.ReadLine();
                    Console.WriteLine("///// Numero de vehiculos ");
                    

                    Console.WriteLine("///// '\n");
                    //tallerMecanico.CrearCliente(nombre,numeroVehiculos,correoElectronico, metodoPago,direccion,tallerMecanico);
                    Console.WriteLine("///// El cliente ha sido creado exitosamente  y ha sido aniadido a la lista de clientes del taller");
                    return InterfazAbierta = true;

                case 3:
                    tallerMecanico.ListaDeClientes();
                    return InterfazAbierta = true;
                case 4:
                    return InterfazAbierta = false;

                default:
                    return InterfazAbierta = true;
            }
            return InterfazAbierta = true;
        }







        
        

    }




}