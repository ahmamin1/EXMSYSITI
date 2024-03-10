using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSys.Models
{
    public enum ExamType
    {
        FinalExam,
        PracticalExam
    }
    public class Exam : BaseEntity
    {
        [Key]
        public int ExamId { get; set; }
        public ExamType Type { get; set; }
        public double Grade { get; set; }

        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        [ForeignKey("CreatedBy")]
        public int CreatedById { get; set; }
        public virtual Teacher CreatedBy { get; set; }

        public ICollection<Questions> Questions { get; set; }
    }
}
