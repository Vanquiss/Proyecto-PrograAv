


namespace TallerMecanico
{
    class AutoPasajeros : Vehiculo
    {


        //atributos
        private int NumeroPuertas;
        private string TamanioMotor;
        private string Carroceria;
        private string TipoCombustible;
        private string TipoFrenos;
        private string Color;

        //constructor
        public AutoPasajeros(string marca, string modelo, int anio,string matricula,Cliente duenioID, List<string> listaServiciosRealizados,
                             int numeroPuertas, string carroceria, string color)
                             : base(marca, modelo, anio, matricula, duenioID,listaServiciosRealizados)
        {
            this.NumeroPuertas = numeroPuertas;
            this.Carroceria = carroceria;
            this.Color = color;
        }


        //metodos

        public int GetPuertas
        {
            get{ return NumeroPuertas;}
        }


        public string GetCarroceria
        {
            get{ return Carroceria;}
        }

        public string Colores
        {
            get{ return Color;}
            set{Color = value;}
        }

        public override void Info() {
            Console.WriteLine(
                $"Auto {Marca} {Modelo}, año {Anio}, {NumeroPuertas} puertas"
            );
        }


    }
}