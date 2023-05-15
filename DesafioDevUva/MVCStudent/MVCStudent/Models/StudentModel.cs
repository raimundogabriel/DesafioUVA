using System.ComponentModel.DataAnnotations;

namespace MVCStudent.Models
{
    public class StudentModel
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
