// Cliente que utiliza la Fábrica Abstracta
class Cliente
{
    public void RealizarPedido(IFabricaMuebles fabrica)
    {
        var silla = fabrica.CrearSilla();
        var mesa = fabrica.CrearMesa();

        Console.WriteLine("Pedido: ");
        silla.MostrarInfo();
        mesa.MostrarInfo();
    }
}
