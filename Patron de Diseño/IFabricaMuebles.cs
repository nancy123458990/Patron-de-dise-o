using System;

// Definimos las interfaces Fábrica Abstracta y Productos Abstractos
public interface IFabricaMuebles
{
    ISilla CrearSilla();
    IMesa CrearMesa();
}

public interface ISilla
{
    void MostrarInfo();
}

public interface IMesa
{
    void MostrarInfo();
}