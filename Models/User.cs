using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSys.Models
{
    public class User : BaseEntity
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }

    public class Student : User
    {
        public ICollection<Subject>? Subjects { get; set; }
        public ICollection<StudentsExams>? StudentsExams { get; set; } = new List<StudentsExams>();

    }

    public class Teacher : User
    {
        public ICollection<Subject>? Subjects { get; set; }
    }

    public class Admin : User
    {

    }
}
