using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModels
{
   
    public class User: BaseEntity
    {
        [Key]
        public int UserId { get; set; }
       public string Username { get; set; }
        public string Password { get; set; }
      
    }

    public class Student : User
    {
        public ICollection<Subject> Subjects { get; set; }
    }

    public class Teacher : User
    {

        public ICollection<Subject> Subjects { get; set; }
    }

    public class Admin : User
    {
       
    }

}
