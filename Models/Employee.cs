using System.ComponentModel.DataAnnotations;

namespace EmpManagement.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; } // Auto-incremented by default in EF Core for primary keys

        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        [MaxLength(10, ErrorMessage = "Phone Number cannot exceed 10 digits.")]
        public string PhoneNumber { get; set; }
    }
}
