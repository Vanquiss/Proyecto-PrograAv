using System.Dynamic;
using System.Collections.Generic;
namespace TallerMecanico{


    class Trabajadores : IPersona
    {
        //Atributos
        public string RUT { get; set; } //rut
        public string Nombre {get; set;}

        public int Edad {get; set;}

        public string CorreoElectronico{get; set;}
        public string Direccion {get; set;}

        public string NumeroTelefonico {get; set;}

        private List<Cliente> ListaClientes;
  
        private List<Vehiculo> ListaVehiculos {get; set;}


        //constructor
         public Trabajadores(string rut, string nombre,int edad,
                              string correoElectronico,
                              string direccion,
                              string numeroTelefonico,
                              List<Cliente> listaClientes
                              
                              )
                              
        {
            
            this.ListaClientes = listaClientes;
           
        }




     


        //metodos


        public string GetRut
        {
            get {return RUT;}
            set {RUT = value;}
        }

        public String NombrePersona
        {
            get{ return Nombre;}
            set{Nombre = value;}
        }

        public String GetDireccion
        {
            get{ return Direccion;}
            set{Direccion = value;}
        }

         public String GetCorreo
        {
            get{ return CorreoElectronico;}
            set{CorreoElectronico = value;}
        }
        public int EdadPersona
        {
            get{ return Edad;}
            set{Edad = value;}
        }

        public string Telefono
        {
            get{ return NumeroTelefonico;}
            set{NumeroTelefonico = value;}
        }

   
        public void ImprimeClientesAsignados()
        {
            Console.WriteLine("///// Clientes Asignados:  ");
            foreach(Cliente i in ListaClientes)
            {
                Console.WriteLine(i.Nombre);
            }
            Console.WriteLine("'\n'");
        }

         public void Informacion(){
            Console.WriteLine(
                $"///// Nombre: {this.Nombre} '\n'///// Rut: {this.RUT}, '\n'///// Numero Telefonico: {this.NumeroTelefonico} "
            );
            Console.WriteLine(this.ImprimeClientesAsignados);
        }
    }
}