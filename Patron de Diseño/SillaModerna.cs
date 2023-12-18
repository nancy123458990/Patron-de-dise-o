// Implementaciones concretas de los productos
public class SillaModerna : ISilla
{
    public void MostrarInfo()
    {
        Console.WriteLine("Silla Moderna");
    }
}
public class MesaModerna : IMesa
{
    public void MostrarInfo()
    {
        Console.WriteLine("Mesa Moderna");
    }
}

public class SillaVictoriana : ISilla
{
    public void MostrarInfo()
    {
        Console.WriteLine("Silla Victoriana");
    }
}

public class MesaVictoriana : IMesa
{
    public void MostrarInfo()
    {
        Console.WriteLine("Mesa Victoriana");
    }
}