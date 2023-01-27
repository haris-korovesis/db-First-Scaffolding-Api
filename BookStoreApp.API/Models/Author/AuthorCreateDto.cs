using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace BookStoreApp.API.Models.Author
{
    public class AuthorCreateDto
    {
        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
        [Required]
        [StringLength(250)]
        public string Bio { get; set; }
    }
}
