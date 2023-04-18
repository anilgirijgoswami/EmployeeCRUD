using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Models
{
    public class Account
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
