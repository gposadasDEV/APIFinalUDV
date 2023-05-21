namespace APIFinalUDV.Models
{
    public class Asignacion
    {
        public int Id { get; set; }
        public int CodigoCurso { get; set; }
        public string? Seccion { get; set; }
        public int Estudiante { get; set; }
        public DateTime FechaRealizacion { get; set; }
        public int Semestre { get; set; }
        public int Anio {get; set; }

    }
}
