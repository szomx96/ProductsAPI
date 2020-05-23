using System.ComponentModel.DataAnnotations;

namespace productAPI.DTOs
{
    public class ProductReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}