// Models/Product.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebappPart2.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [ForeignKey("UserAccountAdd")]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public UserAccountAdd UserAccountAdd { get; set; }
    }
}