public class FabricaMueblesVictorianos : IFabricaMuebles
{
    public ISilla CrearSilla()
    {
        return new SillaVictoriana();
    }

    public IMesa CrearMesa()
    {
        return new MesaVictoriana();
    }
}