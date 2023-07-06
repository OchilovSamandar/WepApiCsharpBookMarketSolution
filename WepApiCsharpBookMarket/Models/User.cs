using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WepApiCsharpBookMarket.Models
{
    [Table("Users")]
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string  Password { get; set; }

        [Required]
        public Role Role { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required]
        public List<Book> books { get; set; }

        [Required]
        public bool IsEnable { get; set; } = true;


    }
}
