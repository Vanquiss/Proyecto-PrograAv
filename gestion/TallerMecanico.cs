using System.Dynamic;

namespace TallerMecanico{


    class TallerMecanico
    {
        //vars
        public List<Cliente> ListaClientes;

        public List<Vehiculo> ListaVehiculos;

        public List<Pedido> PedidosActivos;

        public List<Pedido> Pedidosinactivos;

        public List<String> AlmacenVehiculos;






        //constructor

        public TallerMecanico(List<Cliente> listaClientes,
                              List<Vehiculo> listaVehiculos,
                              List<Pedido> pedidosActivos,
                              List<Pedido> pedidosinactivos,
                              List<String> almacenVehiculos)
        {
            ListaClientes = listaClientes;
            ListaVehiculos = listaVehiculos;
            PedidosActivos = pedidosActivos;
            Pedidosinactivos = pedidosinactivos;
            AlmacenVehiculos = almacenVehiculos;

        }

        //metodos


        //gestion de clientes
        public void ListaDeClientes()
        {
            foreach (Cliente cliente in ListaClientes)
            {
                Console.WriteLine(cliente.NombreCliente);
            }
        }

        public void AniadirCliente(Cliente nuevoCliente)
        {
            ListaClientes.Add(nuevoCliente);
        }




        
        //gestion de vehiculos



        //gestion trabajadores

    }




}