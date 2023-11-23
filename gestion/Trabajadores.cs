using System.Dynamic;
using System.Collections.Generic;
namespace TallerMecanico{


    class Trabajadores : Persona
    {
        //Atributos

        private List<Cliente> ListaClientes;
        private List<Servicios> ListaServicios;
        private List<Vehiculo> ListaVehiculos {get; set;}


        //constructor
         public Trabajadores(string rut, string nombre,int edad,
                              string correoElectronico,
                              string direccion,
                              string numeroTelefonico,
                              List<Cliente> listaClientes,
                              List<Servicios> listaServicios
                              )
                              :base(rut, nombre,edad, correoElectronico, direccion, numeroTelefonico)
        {
            
            this.ListaServicios = listaServicios;
            this.ListaClientes = listaClientes;
           
        }


        //metodos
        public void ImprimeClientesAsignados()
        {
            Console.WriteLine("///// Clientes Asignados:  ");
            foreach(Cliente i in ListaClientes)
            {
                Console.WriteLine(i.NombrePersona);
            }
            Console.WriteLine("'\n'");
        }

         public override void Informacion(){
            Console.WriteLine(
                $"///// Nombre: {this.NombrePersona} '\n'///// Rut: {this.GetRut}, '\n'///// Numero Telefonico: {this.Telefono} "
            );
            Console.WriteLine(this.ImprimeClientesAsignados);
        }
    }
}