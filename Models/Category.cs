using System.ComponentModel.DataAnnotations;

namespace QuickCOOK.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string CategoryName { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }
        


    }
}
