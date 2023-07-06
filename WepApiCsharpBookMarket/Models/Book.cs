using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WepApiCsharpBookMarket.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public User User { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
