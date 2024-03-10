using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModels { 
    public enum QuestionType
{
    trueFalse,
    multipleChoices,
    choice

}

    public class Questions: BaseEntity
    {
        [Key]
        public int QuestionId { get; set; }
        public int Points { get; set; }
        public string Header { get; set; }
        public QuestionType questionType { get; set; }
     
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }


        public virtual ICollection<Answers> Answers { get; set; }

    }
}
