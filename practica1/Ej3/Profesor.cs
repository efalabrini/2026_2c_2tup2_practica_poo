namespace practica1.Ej3;

public class Profesor : Persona
{
    public override string Saludar()
    {
        return $"Hola soy el profesor {Nombre}";
    }

    public string Explicar()
    {
        return "Estoy explicando";
    }
}