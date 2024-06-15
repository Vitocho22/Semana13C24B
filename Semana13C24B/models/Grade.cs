namespace Semana13C24B.models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Estado { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
