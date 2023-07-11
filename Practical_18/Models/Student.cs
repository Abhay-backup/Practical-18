using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practical_18.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        [RegularExpression(@"^([a-zA-z ]){1,50}", ErrorMessage = "Name only contains the Alphabets")]
        public string Name { get; set; } = "";
        
        [Required]
        [RegularExpression("^(\\+\\d{1,2}\\s?)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}$", ErrorMessage = "Phone Must be Number")]
        public string MobileNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
