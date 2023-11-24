using System.Dynamic;

namespace TallerMecanico{


    abstract class Vehiculo
    {
        //atributos
        public String Marca;
        public String Modelo;

        public int Anio;

        public String Matricula; //identificador

        public Cliente DuenioID; 

        public List<Vehiculo> ListaVehiculos;

        private List<String> ListaServiciosRealizados;




        //constructor
        public Vehiculo(String marca,
                              String modelo,
                              int Anio,
                              String matricula,
                              Cliente duenioID,
                              List<string> listaServiciosRealizados
                              )
        {
            this.Marca = marca;
            this.ListaServiciosRealizados = listaServiciosRealizados;
            this.Modelo = modelo;
            this.Anio = Anio;
            this.Matricula =matricula;
            this.DuenioID = duenioID;
            
            
        }

        //metodos

        public string GetMarca
        {
            get{ return Marca;}
        }

        public string GetModelo
        {
            get{return Modelo;}
        }

        public string GetMatricula
        {
            get{return Matricula;}
        }

        public int GetAnio
        {
            get{return Anio;}
        }

        public string GetDuenio
        {
            get{return DuenioID.Nombre;}
        }

        public List<String> ListaDeServiciosRealizados
        {
            get{return ListaServiciosRealizados;}
        }

        public void AniadirServicioRealizado(String servicio)
        {
            ListaServiciosRealizados.Add(servicio);
        }





        public abstract void Info();
       

    }
}