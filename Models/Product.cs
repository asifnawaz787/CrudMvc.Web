using System;
using System.ComponentModel.DataAnnotations;

namespace CrudMvc.Web.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
} 