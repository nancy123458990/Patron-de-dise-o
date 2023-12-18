class Programa
{
    static void Main()
    {
        // Crear una instancia del cliente
        Cliente cliente = new Cliente();

        // Crear fábricas concretas
        IFabricaMuebles fabricaModerna = new FabricaMueblesModernos();
        IFabricaMuebles fabricaVictoriana = new FabricaMueblesVictorianos();

        // Realizar pedidos con diferentes fábricas
        cliente.RealizarPedido(fabricaModerna);
        cliente.RealizarPedido(fabricaVictoriana);
    }
}