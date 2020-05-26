using System.ComponentModel.DataAnnotations;

namespace productAPI.DTOs
{
    public class UpdateProductRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public float Price { get; set; }
    }
}