using System.ComponentModel.DataAnnotations;

namespace Core.DTOs.Contact
{
    public class CreateContactUsDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}