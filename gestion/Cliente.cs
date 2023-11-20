using System.Dynamic;
using System.Collections.Generic;
namespace TallerMecanico{


    class Cliente
    {
        //Atributos

        private String clienteID;
        private string Nombre {get; set;}
        private string CorreoElectronico{get; set;}
        private string Direccion {get; set;}
        private string NumeroTelefonico {get; set;}
        private string DetallesPago {get; set;} //metodos de pago

        private List<Vehiculo> ListaVehiculos {get; set;}


        //constructor
         public Cliente(string nombre,
                              List<Vehiculo> listaVehiculos,
                              string correoElectronico,
                              string direccion,
                              string detallesPago)
        {
            Nombre = nombre;
            ListaVehiculos = listaVehiculos;
            CorreoElectronico = correoElectronico;
            Direccion = direccion;
            DetallesPago = detallesPago;

        }


        //metodos

        public String NombreCliente
        {
            get{ return Nombre;}
            set{Nombre = value;}
        }

        public void ImprimeListaDeVehiculos()
        {
            foreach(Vehiculo i in ListaVehiculos)
            {
                Console.WriteLine(i.GetMarca);
            }
        }

    }
}