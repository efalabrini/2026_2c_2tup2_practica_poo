public class Persona
{
    public string Nombre { get; set; } = string.Empty;

    public string GetSaludo()
    {
        return $"Hola! mi nombre es {Nombre}.";
    }
}