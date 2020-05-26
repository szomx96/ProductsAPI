using System.ComponentModel.DataAnnotations;

namespace productAPI.DTOs
{
    public class CreateProductRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}