namespace Domain.Model
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string? Direccion { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? FechaNac { get; set; }
        public int Legajo { get; set; }
        public int? TipoPersona { get; set; }

        public Plan? IdPlan { get; set; }

    }
}