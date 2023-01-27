using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.Book
{
    public class BookUpdateDto : BaseDto
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
