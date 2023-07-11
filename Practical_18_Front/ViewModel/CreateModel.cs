using System.ComponentModel.DataAnnotations;

namespace Practical_18_Front.ViewModel
{
    public class CreateModel
    {
        [Required]
        [RegularExpression(@"^([a-zA-z ]){1,50}", ErrorMessage = "Name only contains the Alphabets")]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^(\\+ \\d{1,2}\\s?)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}$", ErrorMessage = "Phone Must be Number")]
        public string MobileNumber { get; set; }

        [Required]
        [StringLength(20)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
