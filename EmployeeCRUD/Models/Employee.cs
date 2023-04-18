using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Employee Name")]
        public string? Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string? Email { get; set; }

        [Required]
        public string? Department { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
     
        public DateTime? RecordCreatedOn { get; set; }

    }
}
