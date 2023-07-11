using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Practical_18_Front.Models
{
    public class Student
    {
     
        public int? StudentID { get; set; }

        
        public string Name { get; set; } = "";

       
        public string MobileNumber { get; set; }

       
        public string Email { get; set; }
    }
}
