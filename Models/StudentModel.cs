using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsingCustomModelBinding.Models
{
    [Table("Student")]
    public class StudentModel
    {
        [Key]
        public string Name { get; set; }
        public string WhichClass { get; set; }
        public string Address { get; set; }
        public int TotalMarks { get; set; }

    }
}
