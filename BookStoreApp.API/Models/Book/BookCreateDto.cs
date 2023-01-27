using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace BookStoreApp.API.Models.Book
{
    public class BookCreateDto : BaseDto
    {
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [Range(1800, 2023)]
        public int Year { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        [StringLength(250, MinimumLength = 10)]
        public string Summary { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }
    }
}
