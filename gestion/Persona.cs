

namespace TallerMecanico
{
    public interface IPersona{ 
        //Atributos

        public string RUT { get; set; } //rut
        public string Nombre {get; set;}

        public int Edad {get; set;}

        public string CorreoElectronico{get; set;}
        public string Direccion {get; set;}

        public string NumeroTelefonico {get; set;}

        //metodos

        String GetRut { get; set; }
       

        String NombrePersona { get; set; }
       

        String GetDireccion { get; set; }
       

        String GetCorreo { get; set; }
      
        int EdadPersona { get; set; }
      

        string Telefono { get; set; }
       
       
        public interface IMostrarinformacion
        {
            void Informacion();
        }
       

        
    }

    
}