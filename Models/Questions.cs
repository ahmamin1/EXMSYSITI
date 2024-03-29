﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExaminationSys.Models
{
    public enum QuestionType
    {
        trueFalse,
        multipleChoices,
        choice

    }

    public class Questions : BaseEntity
    {
        [Key]
        public int QuestionId { get; set; }
        public int Points { get; set; }
        public string ?Header { get; set; }
        public QuestionType QuestionType { get; set; }
        public int ExamId { get; set; }
        public virtual Exam? Exam { get; set; }
        public virtual ICollection<Answer>? Answers { get; set; }

    }
}
