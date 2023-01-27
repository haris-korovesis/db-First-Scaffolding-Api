using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.Author
{
    public class AuthorUpdateDto : BaseDto
    {
        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
        [StringLength(250)]
        public string Bio { get; set; }
    }
}
