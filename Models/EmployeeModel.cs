using System.ComponentModel.DataAnnotations;

namespace DrugStroreAppFull.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Experinece { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string Sex { get; set; }
    }
}
