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




        //constructor
        public Vehiculo(String marca,
                              String modelo,
                              int Anio,
                              String matricula,
                              Cliente duenioID)
        {
            this.Marca = marca;
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
            get{return DuenioID.NombreCliente;}
        }



        public abstract void Info();
       

    }
}