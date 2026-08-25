namespace practica1.Ej3
{
    public class Persona
    {
        public string Nombre { get; set; } = string.Empty;
        protected int Edad { get; set; }

        public void SetEdad(int edad)
        {
            Edad = edad;
        }

        public virtual string Saludar()
        {
            return $"Hola soy {Nombre}";
        }
    }
}