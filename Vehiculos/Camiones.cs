using Microsoft.VisualBasic;

namespace TallerMecanico
{


    class Camiones : Vehiculo
    {
        //atributos
        private string TipoCamion;
        private int CapacidadCarga;
        //constructor
        public Camiones(string marca, string modelo, int anio,string matricula,Cliente duenioID,List<string> listaServiciosRealizados,                                string tipoCamion, int capacidadCarga)
                                : base(marca, modelo, anio, matricula, duenioID,listaServiciosRealizados)
        {
            this.TipoCamion = tipoCamion;
            this.CapacidadCarga = capacidadCarga;
    
        }

        public override void Info() {
            Console.WriteLine(
                $"Auto {Marca} {Modelo}, año {Anio}"
            );
        }
    }
}