namespace Portfolio.Models
{
    public class Persona
    {

        public Persona(string Nombre, int Edad) {
            
            this.Nombre = Nombre;
            this.Edad = Edad;
        }
        public string Nombre { get; set; }

        public int? Edad { get; set; }

    }
}
