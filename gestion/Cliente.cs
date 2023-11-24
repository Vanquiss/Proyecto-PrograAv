using System.Dynamic;
using System.Collections.Generic;

namespace TallerMecanico{
    class Cliente : IPersona
    {
        //Atributos
        public string RUT { get; set; } //rut
        public string Nombre {get; set;}

        public int Edad {get; set;}

        public string CorreoElectronico{get; set;}
        public string Direccion {get; set;}

        public string NumeroTelefonico {get; set;}
        private string DetallesPago {get; set;} //metodos de pago
        private List<Vehiculo> ListaVehiculos {get; set;}


        //constructor
         public Cliente(string rut, string nombre, int edad,
                              string correoElectronico,
                              string direccion,
                              string numeroTelefonico,
                              string detallesPago,
                              List<Vehiculo> listaVehiculos)
        {

            this.ListaVehiculos = listaVehiculos;
            this.DetallesPago = detallesPago;
        }

        public List<Vehiculo> GetListaDeVehiculos
        {
            get {return ListaVehiculos;}
        }  

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

        public string MetodoPago
        {
            get{ return DetallesPago;}
            set{DetallesPago = value;}
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

       

    


        //metodos
        public void ImprimeListaDeVehiculos()
        {
            Console.WriteLine("Lista de vehiculos del cliente: ");
            foreach(Vehiculo i in ListaVehiculos)
            {
                Console.WriteLine($"{i.GetMarca}, {i.GetModelo},  {i.GetMatricula}");
            }
            Console.WriteLine("'\n'");
            
        }

        public void Informacion()
        {
            string datos = $"///// Cliente: {this.Nombre} '\n'///// Rut: {this.RUT}, '\n'///// Numero Telefonico: {this.NumeroTelefonico} '\n'///// Direccion del Cliente: {this.Direccion}"
            ;
                
            this.ImprimeListaDeVehiculos();
        }

    }
}