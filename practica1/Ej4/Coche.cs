namespace practica1.Ej4;

public class Coche : IVehiculo
{
    public int Combustible { get; private set; }

    public Coche(int combustibleInicial)
    {
        Combustible = combustibleInicial;
    }

    public string Conducir()
    {
        if (Combustible > 0)
        {
            return "El coche está siendo manejado";
        }
        
        return "El coche no tiene combustible";
    }

    public bool CargarCombustible(int cantidad)
    {
        Combustible += cantidad;
        return true;
    }
}