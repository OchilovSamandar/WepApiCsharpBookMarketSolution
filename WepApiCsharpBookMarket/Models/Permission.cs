using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WepApiCsharpBookMarket.Models
{
    [Table("Permission")]
    public class Permission
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string  Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public Role Role { get; set; }

        [Required]
        public int RoleId { get; set; }
    }
}