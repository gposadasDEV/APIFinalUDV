namespace APIFinalUDV.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string? NombreEstudiante { get; set; }
        public int Carnet { get; set; }
        public string? Carrera { get; set; }
        public string? Correo { get; set; }
        public int Telefono { get; set; }
        public string? Genero { get; set; }
        public DateTime FechaIngreso { get; set; }

    }
}
