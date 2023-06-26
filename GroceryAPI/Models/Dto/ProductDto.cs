using System.ComponentModel.DataAnnotations;

namespace GroceryAPI.Models.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Brand { get; set; }
        [Required]
        public string Name { get; set; }
        public int BranchId { get; set; }
    }
}
