using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_Oracle.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public string ProductId { get; set; } = String.Empty;
        [StringLength(400)]
        public string ProductName { get; set; } = String.Empty;
        [StringLength(200)]
        public string Manufacturer { get; set; } = String.Empty;
        [StringLength(1000)]
        public string Description { get; set; } = String.Empty;
        public int Price { get; set; }
    }
}
