using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DbModels
{
    public class Answers: BaseEntity
    {
        [Key]
        public int AnswerId { get; set; }

        public string ?Content { get; set; }
        
        public bool IsCorrect { get; set; }

        [ForeignKey("Questions")]
        public int QuestionId { get; set; }
        public virtual Questions Question { get; set; }
    }
}

