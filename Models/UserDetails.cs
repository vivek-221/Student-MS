using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SampleApp.Models
{
    public class UserDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Email ID")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; } = "dummy";
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
