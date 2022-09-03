using System.ComponentModel.DataAnnotations;

namespace DrugStroreAppFull.Models
{
    public class MedicineModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime ProductionDate { get; set; }
        [Required]
        public DateTime Expiration { get; set; }
    }
}
