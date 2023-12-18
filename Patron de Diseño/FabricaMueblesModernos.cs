// Implementaciones concretas de las interfaces
public class FabricaMueblesModernos : IFabricaMuebles
{
    public ISilla CrearSilla()
    {
        return new SillaModerna();
    }

    public IMesa CrearMesa()
    {
        return new MesaModerna();
    }
}
