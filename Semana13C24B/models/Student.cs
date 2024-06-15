using System.Diagnostics;

namespace Semana13C24B.models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int GradeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Grade Grade { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
