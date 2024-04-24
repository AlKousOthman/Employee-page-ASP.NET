using System.ComponentModel.DataAnnotations;

namespace Employee_page.Models
{
    public class AddEmployeeForm
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Department { get; set; }

    }
}
