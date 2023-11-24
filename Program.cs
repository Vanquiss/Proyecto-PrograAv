
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
            List<Trabajadores> listaTrabajadores = new List<Trabajadores>();

      
            List<string> almacenVehiculos = new List<string>();

            //instancia Taller Mecanico
            TallerMecanico tallerMecanico = new TallerMecanico(listaClientes,listaTrabajadores, listaVehiculosTaller,"Direccion123","TallerGregoryHouse1@gmail.com","9345674257",almacenVehiculos);

            //Interfaz
            while(Interfaz(tallerAbierto, tallerMecanico));
        }

        static bool Interfaz(bool tallerAbierto, TallerMecanico tallerMecanico)
        {
            Console.WriteLine("              ////////// TALLER GREGORY HOUSE //////////   ");
            Console.WriteLine("////////// Presione un numero para realizar operaciones del taller");
            Console.WriteLine("////////// 1.- Gestion De Clientes: ");
            Console.WriteLine("////////// 2.- Gestion De Servicios: ");
            Console.WriteLine("////////// 3.- Gestion De Trabajadores: ");

            Console.WriteLine("\n", "\n");
            Console.WriteLine("////////// 9.- Cerrar Taller: ");
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    while(InterfazGesClientes(tallerMecanico));
                    return tallerAbierto = true;
                
                case 2:
                    while(InterfazServicios(tallerMecanico));
                    return tallerAbierto = true;

                case 3:
                    while(InterfazServicios(tallerMecanico));
                    return tallerAbierto = true;
                    
                case 9:
                    Console.WriteLine("////////// TALLER CERRADO //////////");
                    return tallerAbierto = false;
                default:
                    return tallerAbierto = true;
            }
        }


        //instanciado en Interfaz()
        static bool InterfazGesClientes(TallerMecanico tallerMecanico)
        {
            bool InterfazAbierta = true;
           
            Console.WriteLine("////////// Gestion De Clientes: ");
            Console.WriteLine("////////// Presione un numero para realizar operaciones de clientes");
            Console.WriteLine("////////// 1.- Crear Cliente: ");
            Console.WriteLine("////////// 2.- Eliminar Cliente: ");
            Console.WriteLine("////////// 3.- Ver lista de clientes: ");
            Console.WriteLine("////////// 4.- Buscar Cliente: ");
            Console.WriteLine("////////// 9.- Volver a operaciones del taller: ");
            int opcion = int.Parse(Console.ReadLine());




            switch(opcion)
            {
                case 1:
                    //Se piden por teclado los datos del cliente
                    Console.WriteLine("///// Desea datos de un cliente por defecto?: 1.- si   2.- no");
                    int datosDefault = int.Parse(Console.ReadLine());
                    if(datosDefault == 2)
                    {
                        Console.WriteLine("///// Datos del Cliente");
                        Console.WriteLine("///// Rut ");
                        string rut = Console.ReadLine();
                        Console.WriteLine("///// Nombre ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("///// Edad  ");
                        int edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("///// Numero de vehiculos ");
                        int numeroVehiculos = int.Parse(Console.ReadLine());
                        Console.WriteLine("///// Correo Electronico ");
                        string correoElectronico = Console.ReadLine();
                        Console.WriteLine("///// Metodo de Pago ");
                        string metodoPago = Console.ReadLine();
                        Console.WriteLine("///// Direccion ");
                        string direccion = Console.ReadLine();
                        Console.WriteLine("///// Numero telefonico ");
                        string numeroTelefonico = Console.ReadLine();
                        

                    //crea cliente
                        Console.WriteLine("///// '\n");
                        tallerMecanico.CrearCliente(rut,nombre,edad,numeroVehiculos,correoElectronico,direccion,numeroTelefonico,metodoPago, tallerMecanico);
                        Console.WriteLine("///// El cliente ha sido creado exitosamente  y ha sido aniadido a la lista de clientes del taller");
                    }else if (datosDefault == 1){
                        tallerMecanico.CrearCliente();
                        Console.WriteLine("///// El cliente por defecto con RUT unico aleatorio ha sido creado exitosamente y ha sido aniadido a la lista de clientes del taller");
                    }else{Console.WriteLine("Opcion Invalida");}
                    return InterfazAbierta = true;
                case 2:
                    
                    
                    Console.WriteLine("///// Datos del Cliente a ELIMINAR");
                    Console.WriteLine("///// RUT");
                    string RUT = Console.ReadLine();
                    
                    Console.WriteLine("///// '\n");
                    tallerMecanico.EliminarCliente(RUT);

                    return InterfazAbierta = true;
                case 3:
                    tallerMecanico.ListaDeClientes();
                    return InterfazAbierta = true;
                case 4:
                    string rut2 = Console.ReadLine();
                    tallerMecanico.BuscarCliente(rut2);
                    return InterfazAbierta = true;

                case 9:
                    //cierra el gestor de clientes  
                    return InterfazAbierta = false;

                default:
                    return InterfazAbierta = true;
            }
            return InterfazAbierta = true;

        }

        static bool InterfazServicios(TallerMecanico tallerMecanico)
        {
            bool InterfazAbierta = true;

            Console.WriteLine("////////// Gestion De Servicios: ");
            Console.WriteLine("////////// Presione un numero para realizar operaciones de servicios");
            Console.WriteLine("////////// 1.- Prestar Servicio: ");
            Console.WriteLine("////////// 2.- Pago de Servicio/s: ");
            Console.WriteLine("////////// 9.- Volver a operaciones de taller ");
            int opcion = int.Parse(Console.ReadLine());
            try{
                switch(opcion)
                {
                    case 1:

                        Console.WriteLine("////////// Ingrese el rut del cliente: ");
                        string rut = Console.ReadLine();
                        Cliente cliente = tallerMecanico.BuscarCliente(rut);

                        Console.WriteLine("////////// Servicios Disponibles: ");
                        Console.WriteLine("////////// 1.- Cambio de Aceite: ");
                        Console.WriteLine("////////// 2.- Reparar Frenos: ");
                        Console.WriteLine("////////// 3.- Cambio Componentes: ");


                        int opcionServicio = int.Parse(Console.ReadLine());
                        switch(opcionServicio)
                        {
                            case 1:
                                Console.Write("Ingrese la matricula del vehiculo:  ");
                                string matricula = Console.ReadLine();
                                Vehiculo vehiculo = tallerMecanico.BuscarVehiculo(matricula, cliente);
                                tallerMecanico.CambioAceite(vehiculo);
                                return InterfazAbierta = true;
                            case 2:
                                Console.Write("Ingrese la matricula del vehiculo:  ");
                                string matricula2 = Console.ReadLine();
                                Vehiculo vehiculo2 = tallerMecanico.BuscarVehiculo(matricula2, cliente);
                                tallerMecanico.RepararFrenos(vehiculo2);
                                return InterfazAbierta = true;
                            case 3:
                                Console.Write("Ingrese la matricula del vehiculo:  ");
                                string matricula3 = Console.ReadLine();
                                Vehiculo vehiculo3 = tallerMecanico.BuscarVehiculo(matricula3, cliente);
                                tallerMecanico.CambioComponente(vehiculo3);
                                return InterfazAbierta = true;
                        }
                        return InterfazAbierta = true;
                    
                    case 2:
                        Console.WriteLine("////////// Ingrese el rut del cliente: ");
                        string rut2 = Console.ReadLine();
                        Cliente cliente2 = tallerMecanico.BuscarCliente(rut2);

                        tallerMecanico.GenerarBoleta(cliente2);
                        
                        return InterfazAbierta = true;
                    case 9:
                        return InterfazAbierta = false;
                    default:
                        return InterfazAbierta = true;
                }
            }catch(FormatException ex)
            {
                Console.WriteLine("Error de formato, ingrese un numero: " + ex.Message);
                return InterfazAbierta = true;
            }


        }
    }
}