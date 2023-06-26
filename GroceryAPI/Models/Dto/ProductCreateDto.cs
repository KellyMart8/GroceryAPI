using System.ComponentModel.DataAnnotations;

namespace GroceryAPI.Models.Dto
{
    public class ProductCreateDto
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public int BranchId { get; set; }
    }
}
