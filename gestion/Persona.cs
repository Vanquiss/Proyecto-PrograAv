

namespace TallerMecanico
{
    abstract class Persona{ 
    //Atributos

        private String RUT; //rut
        private string Nombre {get; set;}

        private int Edad;

        private string CorreoElectronico{get; set;}
        private string Direccion {get; set;}

        private string NumeroTelefonico;

        //constructor
         public Persona(string rut, string nombre, int edad, string correoElectronico, string direccion, string numeroTelefonico)
        {
            this.RUT = rut;
            this.Nombre = nombre;
            this.Edad = edad;
            this.CorreoElectronico = correoElectronico;
            this.Direccion = direccion;
            this.NumeroTelefonico = numeroTelefonico;
        }


        //metodos

        public String GetRut
        {
            get{ return RUT;}
            set{RUT = value;}
        }

        public String NombrePersona
        {
            get{ return Nombre;}
            set{Nombre = value;}
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

        public abstract void Informacion();

        
    }

    
}