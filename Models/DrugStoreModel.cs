using System.ComponentModel.DataAnnotations;

namespace DrugStroreAppFull.Models
{
    public class DrugStoreModel
    {
        public int Id { get; set; }
        [Required]
        public string DrugName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Capacity { get; set; }

    }
}
