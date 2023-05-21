namespace APIFinalUDV.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public int CodigoCurso { get; set; }
        public string? NombreCurso { get; set; }
        public int Semestre { get; set; }
        public int CreditosOtorgados { get; set; }
    }
}
