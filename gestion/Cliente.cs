using System.Dynamic;
using System.Collections.Generic;

namespace TallerMecanico{
    class Cliente : Persona
    {
        //Atributos
        private string DetallesPago {get; set;} //metodos de pago
        private List<Vehiculo> ListaVehiculos {get; set;}


        //constructor
         public Cliente(string rut, string nombre, int edad,
                              string correoElectronico,
                              string direccion,
                              string numeroTelefonico,
                              string detallesPago,
                              List<Vehiculo> listaVehiculos)
                              : base(rut, nombre,edad, correoElectronico, direccion, numeroTelefonico)
        {

            this.ListaVehiculos = listaVehiculos;
            this.DetallesPago = detallesPago;
        }

        public List<Vehiculo> GetListaDeVehiculos
        {
            get {return ListaVehiculos;}
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

        public override void Informacion(){
            Console.WriteLine(
                $"///// Nombre: {this.NombrePersona} '\n'///// Rut: {this.GetRut}, '\n'///// Numero Telefonico: {this.Telefono} "
            );
            this.ImprimeListaDeVehiculos();
        }

    }
}