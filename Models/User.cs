using System.ComponentModel.DataAnnotations;

namespace quickrecipe.Models
{
    public class User
    {

        [Key]
        public int Id { get; set; }
        [Required]

        public string UserName { get; set; }
        [Required]
        public  string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string mobile { get; set; }
        [Required]
        public string city { get; set; }
                     
    }
}
