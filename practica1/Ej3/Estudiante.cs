namespace practica1.Ej3;

public class Estudiante : Persona
{
    public override string Saludar()
    {
        return $"Hola soy el estudiante {Nombre}";
    }

    public string Estudiar()
    {
        return "Estoy estudiando";
    }

    public string MostrarEdad()
    {
        return $"Mi edad es: {Edad} años";
    }
}