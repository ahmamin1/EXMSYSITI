using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModels
{
    public class Subject: BaseEntity
    {
        [Key]
        public int SubjectId { get; set; }
        public string Name { get; set; }


        public ICollection<Student> Students { get; set; }
        public ICollection <Teacher> Teachers { get; set; }

        public ICollection<Exam> Exams { get; set; }
    }
}
