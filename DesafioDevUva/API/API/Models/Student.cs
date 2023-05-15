using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string StudentName { get; set; }

        public string CPF { get; set; }
        public string Email { get; set; }

        public DateTime Date { get; set; }

        public bool IsActive { get; set; }
    }
}