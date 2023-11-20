
namespace TallerMecanico
{
    class Pedido
    {
        //atributos
        private string Codigo;
        private bool Activo;


        //constructor
        public Pedido(string codigo, bool activo)
        {
            this.Activo = activo;
            this.Codigo = codigo;
        
        }


        //metodos
        public string CodigoID
        {
            get {return Codigo;}
            set {Codigo = value;}
        }

        public bool PedidoActivo
        {
            get {return Activo;}
            set {Activo = value;}
        }



    }
}