using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSys.Models
{
    public class Answer : BaseEntity
    {
        [Key]
        public int AnswerId { get; set; }

        public string? Content { get; set; }

        public bool IsCorrect { get; set; }

        [ForeignKey("Questions")]
        public int QuestionId { get; set; }
        public virtual Questions Question { get; set; }
    }
}
