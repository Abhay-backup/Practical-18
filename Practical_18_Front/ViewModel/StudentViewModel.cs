
using System.ComponentModel.DataAnnotations;

namespace Practical_18_FrontEnd.ViewModel
{
    public class StudentViewModel
    {
        public int StudentID { get; set; }

        [Required]
        
        [RegularExpression(@"^([a-zA-z ]){1,50}", ErrorMessage = "Name only contains the Alphabets")]
        public string Name { get; set; }

        [Required]
       
        [RegularExpression("^(\\+\\d{1,2}\\s?)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}$", ErrorMessage = "Phone Must be Number")]
        public string MobileNumber { get; set; }

        [Required]
        
        public string Email { get; set; }

       
    }
}
