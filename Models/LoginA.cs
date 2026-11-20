using System.ComponentModel.DataAnnotations;    
namespace LoginApp.Models
{
    public class LoginA
    {
        public int Id { get; set; }

        [Required]
        public string? Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

    }
}
